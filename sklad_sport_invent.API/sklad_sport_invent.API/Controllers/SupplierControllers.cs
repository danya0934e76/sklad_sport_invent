using Microsoft.AspNetCore.Mvc;
using sklad_sport_invent.Context;
using sklad_sport_invent.Context.Contacts;
using System.Xml.Linq;

namespace sklad_sport_invent.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly IContext context1;
        public SupplierController(IContext context1)
        {
            this.context1 = context1;
        }

        [HttpGet] //localhost:111224/group 
        public IActionResult GetAllSupplier()
        {

            var supplierlist = context1.Suppliers.ToList();

            return Ok(supplierlist);

        }
        [HttpPost]
        public IActionResult Post(Supplier model)
        {
            var item8 = new Supplier
            {
                Id = Guid.NewGuid(),
                NameP=model.NameP,
                AddressP=model.AddressP,
                TelNumP=model.TelNumP,
                INN=model.INN,
                DoverenoeL=model.DoverenoeL,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "ya",
                UpDatedAt = DateTime.UtcNow,
                UpDatedBy = "ya",


            };
            context1.Suppliers.Add(item8);
            context1.SaveChanges();
            return Ok(item8);
        }
        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var supplierlist = context1.Suppliers.FirstOrDefault(x => x.Id == id);
            return Ok(supplierlist);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var customer123 = context1.Suppliers.FirstOrDefault(x => x.Id == id);
            if (customer123 != null)
            {
                context1.Suppliers.Remove(customer123);
                context1.SaveChanges();
            }
            return Ok();
        }
        [HttpPut("{id:guid}")]
        public IActionResult Edit(Guid id, Supplier model)
        {
            var group19 = context1.Suppliers.FirstOrDefault(x => x.Id == id);
            if (group19 != null)
            {
                return NotFound("нет такого");
            }
           group19.TelNumP=model.TelNumP;
            group19.INN=model.INN;
            group19.NameP=model.NameP;
            group19.AddressP=model.AddressP;
            group19.UpDatedAt = DateTimeOffset.Now;
            context1.SaveChanges();
            return Ok(group19);
        }

    }

}
