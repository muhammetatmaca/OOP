using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORS.efcore.Entities
{
	public class Author
	{
		public int AuthorId { get; set; }
		public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName =>
			string.Concat(FirstName," ",LastName);
        public DateTime CreatedDate { get; set; }
		public ICollection<BookAuthor> BookAuthors { get; set; }

    }
}
