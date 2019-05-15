using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.Model;
using System.Data.Entity;
using System.Diagnostics;

namespace Schoolegister.Repository
{
    public class EmployeeRepository : IGenericRepository<Employee>
    {

        private SchoolContext context;
        public EmployeeRepository()
        {
            this.context = new SchoolContext();
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

        public Employee GetByObj(Employee obj)
        {
            return context.Employees.Find(obj.Id);
        }

        public Employee GetByID(int id)
        {
            return context.Employees.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Employee obj)
        {
            var employee = context.Employees.Find(obj.Id);
            context.Entry(employee).CurrentValues.SetValues(obj);
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
