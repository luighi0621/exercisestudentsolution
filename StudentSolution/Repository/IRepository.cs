using System.Collections.Generic;
namespace StudentSolution.Repository
{
    public interface IRepository<T>
    {
        void Save(T obj);
        void Remove(T obj);
        List<T> GetList();
    }
}
