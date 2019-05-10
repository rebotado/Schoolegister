using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.Model;
using System.Data.Entity;

namespace Schoolegister.Repository
{
    public class EmployeeRepository : IGenericRepository<Employee>
    {

        private SchoolContext context;
        public EmployeeRepository(SchoolContext context)
        {
            this.context = context;
        }
        public void Add(Employee obj)
        {
            context.Employees.Add(obj);
        }

        public void Delete(Employee obj)
        {
            context.Employees.Remove(obj);
        }

        public IEnumerable<Employee> GetAll()
        {
            return context.Employees.ToList();
        }

        public Employee GetByID(Employee obj)
        {
            return context.Employees.Find(obj.Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Employee obj)
        {
            context.Entry(obj).State = EntityState.Modified;
        }

        #region Dispose
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion Dispose
    }
}
