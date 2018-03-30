using System.Collections.Generic;
using System.Linq;
using StudentSolution.Model;

namespace StudentSolution.Search
{
    public class SearchByParam : ISearchable
    {
        private List<Student> _list;
        private string _param;
        private string _value;

        public void SetList(List<Student> list)
        {
            _list = list;
        }

        public void SetParams(string param, string value)
        {
            _param = param;
            _value = value;
        }

        public List<Student> Search()
        {
            List<Student> res = new List<Student>();
            switch (_param.ToLower())
            {
                case "name":
                    res.AddRange(_list.Where(st => st.Name == _value).OrderBy(st => st.Name).ToList());
                    break;
                case "type":
                    res.AddRange(_list.Where(st => string.Compare(st.StudentType.ToString(), _value, true) == 0).OrderBy(st => st.LastUpdate).ToList());
                    break;
                case "gender":
                    res.AddRange(_list.Where(st => string.Compare(st.Gender.ToString(), _value, true)==0).OrderBy(st => st.LastUpdate).ToList());
                    break;
            }
            return res;
        }
    }
}
