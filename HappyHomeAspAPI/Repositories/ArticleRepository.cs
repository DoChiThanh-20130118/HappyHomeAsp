using HappyHomeAspAPI.Data;
using HappyHomeAspAPI.Models;
using HappyHomeAspAPI.Repositories.IRepository;

namespace HappyHomeAspAPI.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ApplicationDbContext _context;
        public ArticleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Article> GetAllArticles()
        {
            return _context.Articles.ToList();
        }
        public Article GetArticleById(int id)
        {
            return _context.Articles.FirstOrDefault(a => a.Article_id == id);
        }

        public void AddArticle(Article article)
        {
            _context.Articles.Add(article);
            _context.SaveChanges();
        }

        public void UpdateArticle(int id, Article article)
        {
            var existingArticle = _context.Articles.FirstOrDefault(a => a.Article_id == id);
            if (existingArticle != null)
            {
                existingArticle.Title = article.Title;
                existingArticle.Content = article.Content;
                existingArticle.Article_category_id = article.Article_category_id;
                _context.SaveChanges();
            }
        }

        public void DeleteArticle(int id)
        {
            var article = _context.Articles.FirstOrDefault(a => a.Article_id == id);
            if (article != null)
            {
                _context.Articles.Remove(article);
                _context.SaveChanges();
            }
        }

    }
}
