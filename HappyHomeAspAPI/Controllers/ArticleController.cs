using HappyHomeAspAPI.Models;
using HappyHomeAspAPI.Repositories.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HappyHomeAspAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        // GET api/article
        [HttpGet]
        public ActionResult<IEnumerable<Article>> Get()
        {
            return Ok(_articleRepository.GetAllArticles());
        }

        // GET api/article/5
        [HttpGet("{id}")]
        public ActionResult<Article> Get(int id)
        {
            var article = _articleRepository.GetArticleById(id);
            if (article == null)
            {
                return NotFound();
            }
            return Ok(article);
        }

        // POST api/article
        [HttpPost]
        public ActionResult Post([FromBody] Article value)
        {
            _articleRepository.AddArticle(value);
            return Ok();
        }

        // PUT api/article/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Article value)
        {
            _articleRepository.UpdateArticle(id, value);
            return Ok();
        }

        // DELETE api/article/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _articleRepository.DeleteArticle(id);
            return Ok();
        }
    }
}