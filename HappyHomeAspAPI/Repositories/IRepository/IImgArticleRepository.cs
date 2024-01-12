using HappyHomeAspAPI.Models;

namespace HappyHomeAspAPI.Repositories.IRepository
{
    public interface IImgArticleRepository
    {
        IEnumerable<ImgArticle> GetAllImgArticles();
        ImgArticle GetImgArticleById(int id);
        void AddImgArticle(ImgArticle imgArticle);
        void UpdateImgArticle(int id, ImgArticle imgArticle);
        void DeleteImgArticle(int id);
    }
}
