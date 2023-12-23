using Microsoft.AspNetCore.Mvc;
using sklad_sport_invent.Context;
using sklad_sport_invent.Context.Contacts;

namespace sklad_sport_invent.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IContext context1;
        public StoreController(IContext context1)
        {
            this.context1 = context1;
        }

        [HttpGet] //localhost:111224/group 
        public IActionResult GetAllStore()
        {


  
            var storelist = context1.Suppliers.ToList();

            return Ok(storelist);

        }
        [HttpPost]
        public IActionResult Post(Store model)
        {
            var item5 = new Store
            {
                Id = Guid.NewGuid(),
                NameS=model.NameS,
                AddressSkl=model.AddressSkl,
                ContactFace=model.ContactFace,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "ya",
                UpDatedAt = DateTime.UtcNow,
                UpDatedBy = "ya",


            };
            context1.Stores.Add(item5);
            context1.SaveChanges();
            return Ok(item5);
        }

        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var storelist = context1.Stores.FirstOrDefault(x => x.Id == id);
            return Ok(storelist);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var customer17 = context1.Stores.FirstOrDefault(x => x.Id == id);
            if (customer17 != null)
            {
                context1.Stores.Remove(customer17);
                context1.SaveChanges();
            }
            return Ok();
        }
        [HttpPut("{id:guid}")]
        public IActionResult Edit(Guid id, Store model)
        {
            var group16 = context1.Stores.FirstOrDefault(x => x.Id == id);
            if (group16 != null)
            {
                return NotFound("нет такого");
            }
            group16.NameS=model.NameS;
            group16.AddressSkl=model.AddressSkl;
            group16.ContactFace=model.ContactFace;
            group16.UpDatedAt = DateTimeOffset.Now;
            context1.SaveChanges();
            return Ok(group16);
        }
    }

}
