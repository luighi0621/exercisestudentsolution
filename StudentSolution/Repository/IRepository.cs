using StudentSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSolution.Repository
{
    public interface IRepository<T>
    {
        void Save(T obj);
        void Remove(T obj);
        List<T> GetList();
    }
}
