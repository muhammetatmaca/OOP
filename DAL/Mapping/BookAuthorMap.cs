using EFCORS.efcore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORS.efcore.DAL.Mapping
{
	public class BookAuthorMap : IEntityTypeConfiguration<BookAuthor>
	{
		public void Configure(EntityTypeBuilder<BookAuthor> builder)
		{
			builder.HasKey(ba=>ba.AuthorId);

			builder.HasOne(ba => ba.Book)
				.WithMany(b => b.BookAuthors)
				.HasForeignKey(b => b.BookId);

			builder.HasOne(ba => ba.Author)
				.WithMany(a => a.BookAuthors)
				.HasForeignKey(ba => ba.AuthorId);

				
				
		}
	}
}
