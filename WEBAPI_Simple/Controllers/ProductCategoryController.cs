using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi_simple.models;
using WEBAPI_Simple.Models;

namespace WEBAPI_Simple.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductCategoryController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public ActionResult Get()
        {
            var data = _context.CatwiseProducts.FromSqlInterpolated($"dbo.SP_ProductByCategory");
            return Ok(data);
        }
        [HttpGet]
        [Route("GetDetails/{id:int}")]



        public ActionResult GetDetails(int id)
        {
            var data = _context.CatwiseProducts.FromSqlInterpolated($"dbo.SP_ProductByCategoryId {id}");
            return Ok(data);

        }
    }
}
