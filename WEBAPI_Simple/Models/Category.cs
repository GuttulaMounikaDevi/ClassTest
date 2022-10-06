using System.ComponentModel.DataAnnotations;

namespace WEBAPI_Simple.Models
{
    public class Category
    {
        [Key]
        public int CatId{ get; set; }
        public string CatName { get; set; }
    }
}
