using System.ComponentModel.DataAnnotations;

namespace WEBAPI_Simple.Models
{
    public class ProductCatViewModel
    {
        [Key]
        public int ProductID { get; set; }
		public int CatID { get; set; }
		public string ProductName { get; set; }
		public decimal Price { get; set; }
        
        public string CatName { get; set; }
        
    }
}
