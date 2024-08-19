using CURDwithCqrsandRepository.Core.Domain;

namespace CURDwithCqrsandRepository.Core.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAll();
    }
}
