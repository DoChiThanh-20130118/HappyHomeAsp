using HappyHomeAspAPI.Data;
using HappyHomeAspAPI.Models;
using HappyHomeAspAPI.Repositories.IRepository;

namespace HappyHomeAspAPI.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly ApplicationDbContext _context;
        public ImageRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Image> GetAllImages()
        {
            return _context.Images.ToList();
        }

        public Image GetImageById(int id)
        {
            return _context.Images.FirstOrDefault(a => a.img_id == id);
        }

        public void AddImage(Image img)
        {
            _context.Images.Add(img);
            _context.SaveChanges();
        }

        public void UpdateImage(int id, Image img)
        {
            var existingImage = _context.Images.FirstOrDefault(a => a.img_id == id);
            if (existingImage != null)
            {
                existingImage.product_id = img.product_id;
                existingImage.img_url = img.img_url;
                _context.SaveChanges();
            }
        }

        public void DeleteImage(int id)
        {
            var img = _context.Images.FirstOrDefault(a => a.img_id == id);
            if (img != null)
            {
                _context.Images.Remove(img);
                _context.SaveChanges();
            }
        }

    }
}
