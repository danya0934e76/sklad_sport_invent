using Microsoft.AspNetCore.Mvc;
using sklad_sport_invent.Context;
using sklad_sport_invent.Context.Contacts;

namespace sklad_sport_invent.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NakladnayaController : ControllerBase

    {
        private readonly IContext context1;
        public NakladnayaController(IContext context1)
        {
            this.context1 = context1;
        }

        [HttpGet] //localhost:111224/group 
        public IActionResult GetAllNakladnaya()
        {

          
            var nakladnayalist = context1.Nakladnaya.ToList();

            return Ok(nakladnayalist);

        }
        [HttpPost]
        public IActionResult Post(Nakladnaya model)
        {
            var item2 = new Nakladnaya
            {
               CustomerId=model.CustomerId,
                Itrems=model.Itrems,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "ya",
                UpDatedAt = DateTime.UtcNow,
                UpDatedBy = "ya",


            };
            context1.Nakladnaya.Add(item2);
            context1.SaveChanges();
            return Ok(item2);
        }

        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var nakladnayalist = context1.Nakladnaya.FirstOrDefault(x => x.Id == id);
            return Ok(nakladnayalist);
        }
        [HttpDelete("{id}")]
        public IActionResult actionResultDelete(Guid id)
        {
            var customer123 = context1.Nakladnaya.FirstOrDefault(x => x.Id == id);
            if (customer123 != null)
            {
                context1.Nakladnaya.Remove(customer123);
                context1.SaveChanges();
            }
            return Ok();
        }
        [HttpPut("{id:guid}")]
        public IActionResult Edit(Guid id, Nakladnaya model)
        {
            var group1 = context1.Nakladnaya.FirstOrDefault(x => x.Id == id);
            if (group1 != null)
            {
                return NotFound("нет такого");
            }
            group1.CustomerId= model.CustomerId;
            group1.Itrems=model.Itrems;
            group1.Itrems = model.Itrems;
            group1.UpDatedAt = DateTimeOffset.Now;
            context1.SaveChanges();
            return Ok(group1);
        }

    }

}
