using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olpak.genericarraylist
{
    public class Book
    {
        public Book()
        {
            
        }
        public Book(int id, string tittle, decimal price)
        {
            Id = id;
            Tittle = tittle;
            Price = price;
        }

        public int Id { get; set; }
        public string Tittle { get; set; }
        public decimal Price {  get; set; }

        public override string ToString()
        {
            return $"{Id,-5}{Tittle,25}{Price,-10}";
        }
    }
}
