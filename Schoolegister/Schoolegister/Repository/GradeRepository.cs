using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.Model;

namespace Schoolegister.Repository
{
    public class GradeRepository : IGenericRepository<Grade>
    {
        private SchoolContext context;
        public GradeRepository()
        {
            context = new SchoolContext();
        }

        public void Add(Grade obj)
        {
            context.Grades.Add(obj);
        }

        public void Delete(Grade obj)
        {
            context.Grades.Remove(obj);
        }


        public IEnumerable<Grade> GetAll()
        {
            return context.Grades.ToList();
        }

        public Grade GetByObj(Grade obj)
        {
            return context.Grades.Find(obj.Id);
        }

        public Grade GetByID(int id)
        {
            return context.Grades.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Grade obj)
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
