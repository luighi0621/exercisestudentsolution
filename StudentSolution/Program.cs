using StudentSolution.Model;
using StudentSolution.Repository;
using StudentSolution.Search;
using System;
using System.Collections.Generic;
using System.IO;

namespace StudentSolution
{
    class Program
    {
        private static StudentRepository _StudentRepo = StudentRepository.Instance;

        private static List<string> _SearchParams = new List<string>();

        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                LoadDataFromCVS(args[0]);
                for (int i = 1; i < args.Length; i++)
                {
                    _SearchParams.Add(args[i]);
                }
                List<Student> filtered = SearchBy(_SearchParams);
                PrintResult(filtered);
            }
        }

        private static void PrintResult(List<Student> filtered)
        {
            foreach (Student st in filtered)
            {
                Console.WriteLine(st.ToString());
            }
        }

        private static List<Student> SearchBy(List<string> searchParams)
        {
            List<Student> filteredList = _StudentRepo.GetList();
            foreach (string param in searchParams)
            {
                var values = param.Split('=');
                SearchByParam search = new SearchByParam();
                search.SetList(filteredList);
                search.SetParams(values[0], values[1]);
                filteredList = search.Search();
            }
            return filteredList;
        }

        private static void LoadDataFromCVS(string fileName)
        {
            List<Student> res = new List<Student>();
            string pathFile = Path.Combine(Environment.CurrentDirectory, fileName);
            using (var reader = new StreamReader(pathFile))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    Student toAdd = new Student(line);
                    res.Add(toAdd);
                }

            }
            _StudentRepo.AddStudents(res);
        }
    }
}
