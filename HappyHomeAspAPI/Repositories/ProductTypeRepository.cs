using HappyHomeAspAPI.Data;
using HappyHomeAspAPI.Models;
using HappyHomeAspAPI.Repositories.IRepository;

namespace HappyHomeAspAPI.Repositories
{
    public class ProductTypeRepository : IProductTypeRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductType> GetAllProductTypes()
        {
            return _context.ProductTypes.ToList();
        }

        public ProductType GetProductTypeById(int id)
        {
            return _context.ProductTypes.FirstOrDefault(p => p.type_id == id);
        }

        public void AddProductType(ProductType productType)
        {
            _context.ProductTypes.Add(productType);
            _context.SaveChanges();
        }

        public void UpdateProductType(int id, ProductType productType)
        {
            var existingProductType = _context.ProductTypes.FirstOrDefault(p=>p.type_id == id);
            if (existingProductType != null)
            {
                existingProductType.type_name = productType.type_name;
                _context.SaveChanges();
            }
        }

        public void DeleteProductType(int id)
        {
            var productType = _context.ProductTypes.FirstOrDefault(p => p.type_id == id);
            if (productType != null)
            {
                _context.ProductTypes.Remove(productType);
                _context.SaveChanges();
            }
        }

    }
}
