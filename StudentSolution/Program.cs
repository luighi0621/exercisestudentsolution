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
        private static StudentRepository StudentRepo = StudentRepository.Instance;

        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                LoadDataFromCVS(args[0]);
                foreach (string arg in args)
                {
                    Console.WriteLine(arg);
                }
            }
        }

        private static void LoadDataFromCVS(string pathFile)
        {
            List<Student> res = new List<Student>();
            using (var reader = new StreamReader(pathFile))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    Student toAdd = new Student(line);
                    res.Add(toAdd);
                }

            }
            StudentRepo.AddStudents(res);
        }
    }
}
