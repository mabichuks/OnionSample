using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Entities;
using University.Domain.Interfaces;

namespace University.Infrastructure.DataAccess
{
    public class UniversityRepository<TEntity> : IUniversityRepository<TEntity> where TEntity: class
    {
        protected readonly UniversityDbContext ctxt;
        public UniversityRepository()
        {
            ctxt = new UniversityDbContext();
        }
        public void Add(TEntity entity)
        {
            ctxt.Set<TEntity>().Add(entity);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return ctxt.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(int id)
        {
            return ctxt.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return ctxt.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
           ctxt.Set<TEntity>().Remove(entity);
        }
    }
}
