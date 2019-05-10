using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.Model;

namespace Schoolegister.Repository
{
    public class ScheduleRepository : IGenericRepository<Schedule>
    {
        private SchoolContext context;
        public ScheduleRepository(SchoolContext context)
        {
            this.context = context;
        }
        public void Add(Schedule obj)
        {
            context.Schedules.Add(obj);
        }

        public void Delete(Schedule obj)
        {
            context.Schedules.Remove(obj);
        }

        public IEnumerable<Schedule> GetAll()
        {
            return context.Schedules.ToList();
        }

        public Schedule GetByID(Schedule obj)
        {
            return context.Schedules.Find(obj.Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Schedule obj)
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
