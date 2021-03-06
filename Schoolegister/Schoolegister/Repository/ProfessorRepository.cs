﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.Model;
using System.Data.Entity;

namespace Schoolegister.Repository
{
    public class ProfessorRepository : IGenericRepository<Professor>
    {
        private SchoolContext context;
        public ProfessorRepository()
        {
            this.context = new SchoolContext();
        }
        public void Add(Professor obj)
        {
            context.Professors.Add(obj);
        }

        public void Delete(Professor obj)
        {
            context.Professors.Remove(obj);
        }


        public IEnumerable<Professor> GetAll()
        {
            return context.Professors.ToList();
        }

        public Professor GetByObj(Professor obj)
        {
            return context.Professors.Find(obj.Id);
        }
        public Professor GetByID(int id)
        {
            return context.Professors.Find(id);
        }
        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Professor obj)
        {
            var professor = context.Professors.Find(obj.Id);
            context.Entry(professor).CurrentValues.SetValues(obj);
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
