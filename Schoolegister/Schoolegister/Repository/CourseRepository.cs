using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.Model;

namespace Schoolegister.Repository
{
    public class CourseRepository : IGenericRepository<Course>
    {
        private readonly SchoolContext context;
        public CourseRepository(SchoolContext context)
        {
            this.context = context;
        }

        public void Add(Course obj)
        {
            context.Courses.Add(obj);
        }

        public void Delete(Course obj)
        {
            context.Courses.Remove(obj);
        }

        public IEnumerable<Course> GetAll()
        {
            return context.Courses.ToList();
        }

        public Course GetByID(Course obj)
        {
            return context.Courses.Find(obj.Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Course obj)
        {
            context.Entry(obj).State = System.Data.Entity.EntityState.Modified;
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
