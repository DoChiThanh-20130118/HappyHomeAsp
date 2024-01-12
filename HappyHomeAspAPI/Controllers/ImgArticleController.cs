using HappyHomeAspAPI.Models;
using HappyHomeAspAPI.Repositories.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HappyHomeAspAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImgArticleController : ControllerBase
    {
        private readonly IImgArticleRepository _imgArticleRepository;

        public ImgArticleController(IImgArticleRepository imgArticleRepository)
        {
            _imgArticleRepository = imgArticleRepository;
        }

        // GET api/imgarticle
        [HttpGet]
        public ActionResult<IEnumerable<ImgArticle>> Get()
        {
            return Ok(_imgArticleRepository.GetAllImgArticles());
        }

        // GET api/imgarticle/5
        [HttpGet("{id}")]
        public ActionResult<ImgArticle> Get(int id)
        {
            var imgArticle = _imgArticleRepository.GetImgArticleById(id);
            if (imgArticle == null)
            {
                return NotFound();
            }
            return Ok(imgArticle);
        }

        // POST api/imgarticle
        [HttpPost]
        public ActionResult Post([FromBody] ImgArticle value)
        {
            _imgArticleRepository.AddImgArticle(value);
            return Ok();
        }

        // PUT api/imgarticle/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ImgArticle value)
        {
            _imgArticleRepository.UpdateImgArticle(id, value);
            return Ok();
        }

        // DELETE api/imgarticle/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _imgArticleRepository.DeleteImgArticle(id);
            return Ok();
        }
    }
}
