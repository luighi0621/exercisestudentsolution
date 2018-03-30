using StudentSolution.Model;
using StudentSolution.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                SearchBy(_SearchParams);
            }
        }

        private static void SearchBy(List<string> searchParams)
        {
            throw new NotImplementedException();
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
