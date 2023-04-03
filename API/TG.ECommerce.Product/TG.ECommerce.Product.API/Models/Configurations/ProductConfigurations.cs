using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TG.ECommerce.Product.API.Models.Entities;

namespace TG.ECommerce.Product.API.Models.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Entities.Product>
    {
        // product configurations set in database
        public void Configure(EntityTypeBuilder<Entities.Product> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();


            builder.ToTable("Products");

            builder.HasData(

                new Entities.Product { Id = Guid.NewGuid().ToString(), Name = "Bilgisayar",Description= "32 GB RAM oyun bilgisayarı" ,CreatedTime=DateTime.Now,Price=1000,CategoryId="1" },
                new Entities.Product { Id = Guid.NewGuid().ToString(), Name = "Tablet", Description = "Temiz kullanışlı tablet", CreatedTime = DateTime.Now, Price = 500,CategoryId="1" },
                new Entities.Product { Id = Guid.NewGuid().ToString(), Name = "Koşu Bandı", Description = "İkinci el koşu bandı", CreatedTime = DateTime.Now, Price = 2000 , CategoryId = "2" }


                );

        }
    }
}
