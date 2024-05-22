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
	public class BookMap : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> builder)
		{
			builder.HasKey(b => b.BookId);
			builder.Property(b => b.Title)
				.IsRequired()
				.HasMaxLength(50);

			builder.Property(b => b.CreatedTime)
				.IsRequired()
				.HasDefaultValueSql("GETDATE()");

			builder.HasData
				(
				new Book { BookId=1,Title="insanligimi yitirken",CategoryId=3},
				new Book { BookId = 2, Title = "insanligimi yitirmezken",CategoryId = 3 },
				new Book { BookId = 3, Title = "insanligimi yitirebilirken" , CategoryId = 3 }
				);

			builder.HasOne(b => b.Category)
				.WithMany(b => b.Books)
				.HasForeignKey(b => b.CategoryId)
				.OnDelete(DeleteBehavior.Cascade);
		
		}
	}
}
