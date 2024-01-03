using HappyHomeAspAPI.Data;
using HappyHomeAspAPI.Models;
using HappyHomeAspAPI.Repositories.IRepository;
using System.Linq;

namespace HappyHomeAspAPI.Repositories
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public ArticleCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ArticleCategory> GetAllArticleCategories()
        {
            return _context.ArticleCategories.ToList();
        }

        public ArticleCategory GetArticleCategoryById(int id)
        {
            return _context.ArticleCategories.FirstOrDefault(a => a.Article_category_id == id);
        }

        public void AddArticleCategory(ArticleCategory articleCategory)
        {
            _context.ArticleCategories.Add(articleCategory);
            _context.SaveChanges();
        }

        public void UpdateArticleCategory(int id, ArticleCategory articleCategory)
        {
            var existingArticleCategory = _context.ArticleCategories.FirstOrDefault(a => a.Article_category_id == id);
            if (existingArticleCategory != null)
            {
                existingArticleCategory.Article_category_name = articleCategory.Article_category_name;
                _context.SaveChanges();
            }
        }

        public void DeleteArticleCategory(int id)
        {
            var articleCategory = _context.ArticleCategories.FirstOrDefault(a => a.Article_category_id == id);
            if (articleCategory != null)
            {
                _context.ArticleCategories.Remove(articleCategory);
                _context.SaveChanges();
            }
        }
    }
}
