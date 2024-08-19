using CURDwithCqrsandRepository.Core.AppDbContext;
using CURDwithCqrsandRepository.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace CURDwithCqrsandRepository.Core.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _productDbContext;
        public ProductRepository(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _productDbContext.Producttbl.ToListAsync();
        }
    }
}
