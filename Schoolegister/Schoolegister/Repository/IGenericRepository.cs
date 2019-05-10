using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolegister.Repository
{
    public interface IGenericRepository<T>: IDisposable where T: class
    {
        IEnumerable<T> GetAll();
        T GetByID(T obj);
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
        void Save();
    }
}
