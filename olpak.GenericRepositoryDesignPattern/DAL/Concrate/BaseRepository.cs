using olpak.GenericRepositoryDesignPattern.DAL.Abstract;
using olpak.GenericRepositoryDesignPattern.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olpak.GenericRepositoryDesignPattern.DAL.Concrate
{
    public class BaseRepository<T> : IentityRepository<T>
        where T : class, IEntitycs, new()
    {
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int entityid)
        {
            throw new NotImplementedException();
        }

        public T Get()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
