using olpak.GenericRepositoryDesignPattern.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olpak.GenericRepositoryDesignPattern.DAL.Abstract
{
    public interface IentityRepository<T>
        where T : class,IEntitycs,new()
    {

        void Create(T entity);  //create
        List<T> GetAll();// rety
        T Get();// tek read

        void Update(T entity);

        void Delete(int entityid);

    }
}
