using HappyHomeAspAPI.Data;
using HappyHomeAspAPI.Models;
using HappyHomeAspAPI.Repositories.IRepository;

namespace HappyHomeAspAPI.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _context;
        public CartRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cart> GetAllCarts()
        {
            return _context.Carts.ToList();
        }
        public Cart GetCartById(int id)
        {
            return _context.Carts.FirstOrDefault(a => a.cart_id == id);
        }

        public void AddCart(Cart cart)
        {
            _context.Carts.Add(cart);
            _context.SaveChanges();
        }

        public void UpdateCart(int id, Cart cart)
        {
            var existingCart = _context.Carts.FirstOrDefault(a => a.cart_id == id);
            if (existingCart != null)
            {
                existingCart.id_product = cart.id_product;
                existingCart.user_name = cart.user_name;
                existingCart.amount = cart.amount;
                existingCart.total_money = cart.total_money;
                _context.SaveChanges();
            }
        }

        public void DeleteCart(int id)
        {
            var cart = _context.Carts.FirstOrDefault(a => a.cart_id == id);
            if (cart != null)
            {
                _context.Carts.Remove(cart);
                _context.SaveChanges();
            }
        }

    }
}
