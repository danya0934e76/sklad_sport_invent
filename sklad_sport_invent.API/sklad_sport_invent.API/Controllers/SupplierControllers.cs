using Microsoft.AspNetCore.Mvc;
using sklad_sport_invent.Context;
using sklad_sport_invent.Context.Contacts;

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
        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var supplierlist = context1.Suppliers.FirstOrDefault(x => x.Id == id);
            return Ok(supplierlist);
        }

    }

}
