using HappyHomeAspAPI.Data;
using HappyHomeAspAPI.Models;
using HappyHomeAspAPI.Repositories.IRepository;

namespace HappyHomeAspAPI.Repositories
{
    public class ImgArticleRepository : IImgArticleRepository
    {
        private readonly ApplicationDbContext _context;
        public ImgArticleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ImgArticle> GetAllImgArticles()
        {
            return _context.ImgArticles.ToList();
        }
        public ImgArticle GetImgArticleById(int id)
        {
            return _context.ImgArticles.FirstOrDefault(a => a.img_article_id == id);
        }

        public void AddImgArticle(ImgArticle imgArticle)
        {
            _context.ImgArticles.Add(imgArticle);
            _context.SaveChanges();
        }

        public void UpdateImgArticle(int id, ImgArticle imgArticle)
        {
            var existingImgArticle = _context.ImgArticles.FirstOrDefault(a => a.img_article_id == id);
            if (existingImgArticle != null)
            {
                existingImgArticle.img_article_id = imgArticle.img_article_id;
                existingImgArticle.article_id = imgArticle.article_id;
                _context.SaveChanges();
            }
        }

        public void DeleteImgArticle(int id)
        {
            var imgArticle = _context.ImgArticles.FirstOrDefault(a => a.img_article_id == id);
            if (imgArticle != null)
            {
                _context.ImgArticles.Remove(imgArticle);
                _context.SaveChanges();
            }
        }
    }
}

