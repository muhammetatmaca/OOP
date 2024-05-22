using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORS.efcore.Entities
{
	public class Book
	{
		public int BookId { get; set; }
		public string Title { get; set; }
        public int Price { get; set; }
        public DateTime CreatedTime { get; set; }
        public int? CategoryId { get; set; }
		public Category Category { get; set; }
		public BookDetail BookDetail { get; set; }

		public ICollection<BookAuthor> BookAuthors { get; set;}

    }}
