using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.Model;

namespace Schoolegister.Repository
{
    public class CourseStudentsRepository : IGenericRepository<CourseStudents>
    {
        private SchoolContext context;
        public CourseStudentsRepository()
        {
            context = new SchoolContext();
        }

        public void Add(CourseStudents obj)
        {
            context.CourseStudents.Add(obj);
        }

        public void Delete(CourseStudents obj)
        {
            context.CourseStudents.Remove(obj);
        }


        public IEnumerable<CourseStudents> GetAll()
        {
            return context.CourseStudents.ToList();
        }

        public CourseStudents GetByID(CourseStudents obj)
        {
            return context.CourseStudents.Find(obj.Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(CourseStudents obj)
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
