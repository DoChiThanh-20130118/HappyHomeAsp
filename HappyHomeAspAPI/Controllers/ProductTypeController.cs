using HappyHomeAspAPI.Models;
using HappyHomeAspAPI.Repositories.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HappyHomeAspAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private readonly IProductTypeRepository _productTypeRepository;

        public ProductTypeController(IProductTypeRepository productTypeRepository)
        {
            _productTypeRepository = productTypeRepository;
        }

        // GET api/producttype
        [HttpGet]
        public ActionResult<IEnumerable<ProductType>> Get()
        {
            return Ok(_productTypeRepository.GetAllProductTypes());
        }

        // GET api/producttype/5
        [HttpGet("{id}")]
        public ActionResult<ProductType> Get(int id)
        {
            var productType = _productTypeRepository.GetProductTypeById(id);
            if (productType == null)
            {
                return NotFound();
            }
            return Ok(productType);
        }

        // POST api/producttype
        [HttpPost]
        public ActionResult Post([FromBody] ProductType value)
        {
            _productTypeRepository.AddProductType(value);
            return Ok();
        }

        // PUT api/producttype/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ProductType value)
        {
            _productTypeRepository.UpdateProductType(id, value);
            return Ok();
        }

        // DELETE api/producttype/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _productTypeRepository.DeleteProductType(id);
            return Ok();
        }
    }
}
