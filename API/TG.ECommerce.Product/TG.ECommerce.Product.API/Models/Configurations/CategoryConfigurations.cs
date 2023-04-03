using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using TG.ECommerce.Product.API.Models.Entities;

namespace TG.ECommerce.Product.API.Models.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        // category configurations set in database
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();


            builder.ToTable("Categories");

            builder.HasData(

                new Category { Id = "1", Name = "Elektronik" },
                new Category { Id = "2", Name = "Spor" },
                new Category { Id = "3", Name = "Giyim" }


                );

        }
    }
}
