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
        [HttpPost]
        public IActionResult Post(Product model)
        {
            var item4 = new Product
            {
                Id = Guid.NewGuid(),
                NameProduct=model.NameProduct,
                MeraIzmer=model.MeraIzmer,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "ya",
                UpDatedAt = DateTime.UtcNow,
                UpDatedBy = "ya",


            };
            context1.Products.Add(item4);
            context1.SaveChanges();
            return Ok(item4);
        }
        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var productlist = context1.Products.FirstOrDefault(x => x.Id == id);
            return Ok(productlist);
        }

        [HttpDelete("{id}")]
        public IActionResult actionResultDelete(Guid id)
        {
            var customer124= context1.Products.FirstOrDefault(x => x.Id == id);
            if (customer124 != null)
            {
                context1.Products.Remove(customer124);
                context1.SaveChanges();
            }
            return Ok();
        }
        [HttpPut("{id:guid}")]
        public IActionResult Edit(Guid id, Product model)
        {
            var group15 = context1.Products.FirstOrDefault(x => x.Id == id);
            if (group15 != null)
            {
                return NotFound("нет такого");
            }
          group15.NameProduct= model.NameProduct;
            group15.valueUnit= model.valueUnit;
            group15.MeraIzmer= model.MeraIzmer;
            group15.UpDatedAt = DateTimeOffset.Now;
            context1.SaveChanges();
            return Ok(group15);
        }
    }

}
