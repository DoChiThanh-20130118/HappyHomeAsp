using System.ComponentModel.DataAnnotations;

namespace HappyHomeAspAPI.Models
{
    public class ProductType
    {
        [Key]
        public int type_id { get; set; }
        public string type_name { get; set; }
        public ProductType(int type_id, string type_name)
        {
            this.type_id = type_id;
            this.type_name = type_name;
        }

        public ProductType()
        {
        }
    }
}
