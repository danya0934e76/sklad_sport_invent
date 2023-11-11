using Microsoft.AspNetCore.Mvc;
using sklad_sport_invent.Context;

namespace sklad_sport_invent.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SupplierController : ControllerBase
    {
        [HttpGet] //localhost:111224/group 
        public IActionResult GetAllSupplier()
        {

            var context = new SkladContext();
            var supplierlist = context.Suppliers.ToList();

            return Ok(supplierlist);

        }


    }

}
