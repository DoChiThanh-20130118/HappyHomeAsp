using System.ComponentModel.DataAnnotations;

namespace HappyHomeAspAPI.Models
{
    public class Image
    {
        [Key]
        public int img_id {  get; set; }

        public int product_id { get; set; }

        public string img_url { get; set; }

    }
}
