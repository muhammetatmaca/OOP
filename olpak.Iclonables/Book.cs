using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olpak.Iclonables
{
    public class Book :ICloneable
    {
        public int Id { get; set; }
        public string Tittle {  get; set; }
        public double Price { get; set; }

        public object Clone()
        {
           //return new Book() { Id=this.Id,Tittle=this.Tittle,Price=this.Price };
            

           return this.MemberwiseClone();
        }
    }
}
