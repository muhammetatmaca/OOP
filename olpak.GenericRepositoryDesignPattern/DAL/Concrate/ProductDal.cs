using olpak.GenericRepositoryDesignPattern.DAL.Abstract;
using olpak.GenericRepositoryDesignPattern.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olpak.GenericRepositoryDesignPattern.DAL.Concrate
{
    public class ProductDal : BaseRepository<Product>, IProductDal
    {
      
    }
}
