using HappyHomeAspAPI.Models;
using HappyHomeAspAPI.Repositories.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HappyHomeAspAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageRepository _imageRepository;

        public ImageController(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        // GET api/image
        [HttpGet]
        public ActionResult<IEnumerable<Image>> Get()
        {
            return Ok(_imageRepository.GetAllImages());
        }

        // GET api/image/5
        [HttpGet("{id}")]
        public ActionResult<Image> Get(int id)
        {
            var image = _imageRepository.GetImageById(id);
            if (image == null)
            {
                return NotFound();
            }
            return Ok(image);
        }

        // POST api/image
        [HttpPost]
        public ActionResult Post([FromBody] Image value)
        {
            _imageRepository.AddImage(value);
            return Ok();
        }

        // PUT api/image/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Image value)
        {
            _imageRepository.UpdateImage(id, value);
            return Ok();
        }

        // DELETE api/image/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _imageRepository.DeleteImage(id);
            return Ok();
        }
    }
}
