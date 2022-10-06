using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WEBAPI_Simple.Models;

namespace WEBAPI_Simple.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public List<Product> Productlist;

        public ProductController()
        {
            Productlist = new List<Product>()
        {
            new Product()
           
        };
        }
        public ActionResult Get()
        {
            var data = Productlist;
            return Ok(data);
        }
    }
}
