using EFCORS.efcore.DAL.Mapping;
using EFCORS.efcore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORS.efcore.DAL
{
	public class BookAppDbContext:DbContext
	{
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
		public DbSet<BookDetail> BooksDetails { get; set; }
		public DbSet<Author> authors { get; set; }
		public DbSet<BookAuthor> BookAuthors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server = MUHAMMET\\MAMİSQL; Database = Bookdenemedb2;Integrated security = true;TrustServerCertificate=True;");
		}

		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new BookMap());
			modelBuilder.ApplyConfiguration(new CategoryMap());
			modelBuilder.ApplyConfiguration(new BookDetailMap());
			modelBuilder.ApplyConfiguration(new AuthorMap());
			modelBuilder.ApplyConfiguration(new BookAuthorMap());
		}

	}
}
