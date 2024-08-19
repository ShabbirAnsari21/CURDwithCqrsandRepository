using CURDwithCqrsandRepository.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace CURDwithCqrsandRepository.Core.AppDbContext
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Producttbl { get; set; }
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }
    }
}
