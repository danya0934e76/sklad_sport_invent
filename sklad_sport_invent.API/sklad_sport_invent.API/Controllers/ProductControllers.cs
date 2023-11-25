using Microsoft.AspNetCore.Mvc;
using sklad_sport_invent.Context;
using sklad_sport_invent.Context.Contacts;

namespace sklad_sport_invent.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IContext context1;
        public ProductController(IContext context1)
        {
            this.context1 = context1;
        }

        [HttpGet] //localhost:111224/group 
        public IActionResult GetAllProduct()
        {

           
            var productlist = context1.Products.ToList();

            return Ok(productlist);

        }
        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var productlist = context1.Products.FirstOrDefault(x => x.Id == id);
            return Ok(productlist);
        }

    }

}
