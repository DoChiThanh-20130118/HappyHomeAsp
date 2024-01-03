using System.ComponentModel.DataAnnotations;

namespace HappyHomeAspAPI.Models
{
    public class ImgArticle
    {
        [Key]
        public int img_article_id {  get; set; }

        public int article_id { get; set; }
        public string url { get; set; }

        public ImgArticle(int img_article_id, int article_id, string url)
        {
            this.img_article_id = img_article_id;
            this.article_id = article_id;
            this.url = url;
        }
    }
}
