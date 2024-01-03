using HappyHomeAspAPI.Models;

namespace HappyHomeAspAPI.Repositories.IRepository
{
    public interface IImageRepository
    {
        IEnumerable<Image> GetAllImages();
        Image GetImageById(int id);
        void AddImage (Image image);
        void UpdateImage (int id, Image image);
        void DeleteImage(int id);
    }
}
