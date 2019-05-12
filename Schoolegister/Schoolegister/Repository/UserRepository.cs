using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.Model;
using System.Data.Entity;

namespace Schoolegister.Repository
{
    public class UserRepository : IGenericRepository<User>
    {
        private SchoolContext context;
        public UserRepository(SchoolContext context)
        {
            this.context = context;
        }
        public void Add(User obj)
        {
            context.Users.Add(obj);
        }

        public void Delete(User obj)
        {
            context.Users.Remove(obj);
        }


        public IEnumerable<User> GetAll()
        {
            return context.Users.ToList();
        }

        public User GetByID(User obj)
        {
            return context.Users.Find(obj.Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(User obj)
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
