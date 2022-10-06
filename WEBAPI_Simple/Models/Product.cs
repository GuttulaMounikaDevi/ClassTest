using System.ComponentModel.DataAnnotations;

namespace WEBAPI_Simple.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal price { get; set; }
        public int CatId { get; set; }


    }
}
