using Microsoft.AspNetCore.Mvc;
using sklad_sport_invent.Context;

namespace sklad_sport_invent.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet] //localhost:111224/group 
        public IActionResult GetAllProduct()
        {

            var context = new SkladContext();
            var productlist = context.Products.ToList();

            return Ok(productlist);

        }


    }

}
