using HappyHomeAspAPI.Models;
using HappyHomeAspAPI.Repositories.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HappyHomeAspAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleCategoryController : ControllerBase
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryController(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }

        // GET api/articlecategory
        [HttpGet]
        public ActionResult<IEnumerable<ArticleCategory>> Get()
        {
            return Ok(_articleCategoryRepository.GetAllArticleCategories());
        }

        // GET api/articlecategory/5
        [HttpGet("{id}")]
        public ActionResult<ArticleCategory> Get(int id)
        {
            var articleCategory = _articleCategoryRepository.GetArticleCategoryById(id);
            if (articleCategory == null)
            {
                return NotFound();
            }
            return Ok(articleCategory);
        }

        // POST api/articlecategory
        [HttpPost]
        public ActionResult Post([FromBody] ArticleCategory value)
        {
            _articleCategoryRepository.AddArticleCategory(value);
            return Ok();
        }

        // PUT api/articlecategory/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ArticleCategory value)
        {
            _articleCategoryRepository.UpdateArticleCategory(id, value);
            return Ok();
        }

        // DELETE api/articlecategory/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _articleCategoryRepository.DeleteArticleCategory(id);
            return Ok();
        }
    }
}
