using HappyHomeAspAPI.Models;

namespace HappyHomeAspAPI.Repositories.IRepository
{
    public interface IArticleCategoryRepository
    {
        IEnumerable<ArticleCategory> GetAllArticleCategories();
        ArticleCategory GetArticleCategoryById(int id);
        void AddArticleCategory(ArticleCategory articleCategory);
        void UpdateArticleCategory(int id, ArticleCategory articleCategory);
        void DeleteArticleCategory(int id);
    }
}
