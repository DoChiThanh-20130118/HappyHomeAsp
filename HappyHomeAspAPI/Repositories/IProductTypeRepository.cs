using HappyHomeAspAPI.Models;

namespace HappyHomeAspAPI.Repositories
{
    public interface IProductTypeRepository
    {
        IEnumerable<ProductType> GetAllProductTypes();
        ProductType GetProductTypeById(int id);
        void AddProductType(ProductType productType);
        void UpdateProductType(int id, ProductType productType);
        void DeleteProductType(int id);
    }
}
