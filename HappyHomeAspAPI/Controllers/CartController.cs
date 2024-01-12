using HappyHomeAspAPI.Models;
using HappyHomeAspAPI.Repositories.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HappyHomeAspAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository _cartRepository;

        public CartController(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        // GET api/cart
        [HttpGet]
        public ActionResult<IEnumerable<Cart>> Get()
        {
            return Ok(_cartRepository.GetAllCarts());
        }

        // GET api/cart/5
        [HttpGet("{id}")]
        public ActionResult<Cart> Get(int id)
        {
            var cart = _cartRepository.GetCartById(id);
            if (cart == null)
            {
                return NotFound();
            }
            return Ok(cart);
        }

        // POST api/cart
        [HttpPost]
        public ActionResult Post([FromBody] Cart value)
        {
            _cartRepository.AddCart(value);
            return Ok();
        }

        // PUT api/cart/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Cart value)
        {
            _cartRepository.UpdateCart(id, value);
            return Ok();
        }

        // DELETE api/cart/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _cartRepository.DeleteCart(id);
            return Ok();
        }
    }
}
