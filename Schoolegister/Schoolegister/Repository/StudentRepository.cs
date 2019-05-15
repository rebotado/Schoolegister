using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.Model;

namespace Schoolegister.Repository
{
    public class StudentRepository : IGenericRepository<Student>
    {
        private SchoolContext context;
        public StudentRepository()
        {
            this.context = new SchoolContext();
        }

        public void Add(Student obj)
        {
            context.Students.Add(obj);
        }

        public void Delete(Student obj)
        {
            context.Students.Remove(obj);
        }

        public IEnumerable<Student> GetAll()
        {
            return context.Students.ToList();
        }

        public Student GetByObj(Student obj)
        {
            return context.Students.Find(obj.Id);
        }
        public Student GetByID(int id)
        {
            return context.Students.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Student obj)
        {
            var student = context.Students.Find(obj.Id);
            context.Entry(student).CurrentValues.SetValues(obj);
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
