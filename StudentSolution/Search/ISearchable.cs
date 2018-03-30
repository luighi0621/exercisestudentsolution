using StudentSolution.Model;
using System.Collections.Generic;

namespace StudentSolution.Search
{
    public interface ISearchable
    {
        List<Student> Search();
    }
}
