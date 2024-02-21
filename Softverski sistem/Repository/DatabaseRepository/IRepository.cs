using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll(IDomainObject domainObject);
        void Add(T obj);
        void Delete(T obj);
        void Update(T obj);
        List<T> Find(string kriterijum);
        void Open();
        void Close();
        void BeginTransaction();
        void Commit();
        void Rollback();

    }
}
