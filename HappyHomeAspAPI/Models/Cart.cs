using System.ComponentModel.DataAnnotations;

namespace HappyHomeAspAPI.Models
{
    public class Cart
    {
        [Key]
        public int cart_id { get; set; }
        public string user_name { get; set; }
        public int id_product { get; set; }
        public int amount { get; set; }
        public string total_money { get; set; }
    }
}
