using StudentSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSolution.Search
{
    public interface ISearchable
    {
        List<Student> Search();
    }
}
