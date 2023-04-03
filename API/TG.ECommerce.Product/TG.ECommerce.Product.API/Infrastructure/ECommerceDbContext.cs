using Microsoft.EntityFrameworkCore;
using TG.ECommerce.Product.API.Models.Entities;

namespace TG.ECommerce.Product.API.Infrastructure
{
    public class ECommerceDbContext:DbContext
    {
        // created db context
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options) { } 
        public DbSet<Models.Entities.Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        // model configurations
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(builder);
        }
    }
}
