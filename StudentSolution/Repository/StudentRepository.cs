using StudentSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSolution.Repository
{
    public class StudentRepository : IRepository<Student>
    {
        public static StudentRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StudentRepository();
                }
                return _instance;
            }
        }

        private static StudentRepository _instance;

        private StudentRepository() { }

        private static List<Student> _list = new List<Student>()
        {
            new Student("Kinder,Luis,M,20151231145934"),
            new Student("High,Naty,F,20140220180903"),
            new Student("kinder,Naty,F,20100220180903"),
        };

        public List<Student> GetList()
        {
            return _list;
        }

        public void Remove(Student st)
        {
            _list.Remove(st);
        }

        public void Save(Student st)
        {
            _list.Add(st);
        }
    }
}
