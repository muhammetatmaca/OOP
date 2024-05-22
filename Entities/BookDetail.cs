using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORS.efcore.Entities
{
	public class BookDetail
	{
		public int BookDetailId { get; set; }
        public int BookId { get; set; }
		public Book Book { get; set; }
		public string ISNN { get; set; }
        public string City { get; set; }
		public string Country { get; set; }
        public int Year { get; set; }


    }
}
