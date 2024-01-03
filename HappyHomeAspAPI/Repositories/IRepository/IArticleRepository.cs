using HappyHomeAspAPI.Models;

namespace HappyHomeAspAPI.Repositories.IRepository
{
    public interface IArticleRepository
    {
        IEnumerable<Article> GetAllArticles();
        Article GetArticleById(int id);
        void AddArticle(Article article);
        void UpdateArticle(int id, Article article);
        void DeleteArticle(int id);
    }
}
