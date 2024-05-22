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
	public class CategoryMap : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasKey(c => c.CategoryId);
			builder.Property(c=> c.CategoryName)
			.IsRequired()
			.HasMaxLength(50);

			builder.Property(c => c.CategoryDescription)
				.HasDefaultValue("no info");

			builder.HasData
				(
				 new Category { CategoryId = 1, CategoryName = "ilim kurgu", CategoryDescription = "de" },
				 new Category { CategoryId = 2, CategoryName = "durum kurgu" },
				 new Category { CategoryId = 3, CategoryName = "elim kurgu", CategoryDescription = "der" }
				);
		}
	}
}
