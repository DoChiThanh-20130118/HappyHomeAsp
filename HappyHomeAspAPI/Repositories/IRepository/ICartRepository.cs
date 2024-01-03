using HappyHomeAspAPI.Models;

namespace HappyHomeAspAPI.Repositories.IRepository
{
    public interface ICartRepository
    {
        IEnumerable<Cart> GetAllCarts();
        Cart GetCartById(int id);
        void AddCart(Cart cart);
        void UpdateCart(int id, Cart cart);
        void DeleteCart(int id);
    }
}
