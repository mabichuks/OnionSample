using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Entities;
using University.Domain.Interfaces;
using University.Infrastructure.DataAccess;
using University.Services.Interfaces;

namespace University.Services.Concrete
{
    public class UserService<TEntity> : IUserService<TEntity> where TEntity: class
    {
        private IUniversityRepository<TEntity> repo;

        public UserService()
        {
            this.repo = new UniversityRepository<TEntity>();
        }

        public void Add(TEntity entity)
        {
            repo.Add(entity);
        }


        public TEntity Get(int id)
        {
           return repo.Get(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repo.GetAll();
        }

        public void Remove(TEntity entity)
        {
             repo.Remove(entity);
        }
    }
}
