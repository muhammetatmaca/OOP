using EFCORS.efcore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORS.efcore.DAL.Mapping
{
	public class BookDetailMap : IEntityTypeConfiguration<BookDetail>
	{
		public void Configure(EntityTypeBuilder<BookDetail> builder)
		{
			builder.HasKey(bd=>bd.BookDetailId);
			builder.Property(bd => bd.ISNN)
				.IsRequired()
				.HasMaxLength(40)
				.HasDefaultValue("0000-0000-0000");

			builder.Property(bd => bd.Year)
				.HasDefaultValue(DateTime.Now.Year);

			builder.HasOne(bd=>bd.Book)
				.WithOne(b=>b.BookDetail)
				.HasForeignKey<BookDetail>(b=>b.BookId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
