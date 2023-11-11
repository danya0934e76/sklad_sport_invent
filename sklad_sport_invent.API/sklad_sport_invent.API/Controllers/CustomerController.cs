using Microsoft.AspNetCore.Mvc;
using sklad_sport_invent.Context;

namespace sklad_sport_invent.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
public class CustomerController : ControllerBase 
    {
        [HttpGet] //localhost:111224/group 
        public IActionResult GetAllCustomers ()
        {

            var context = new SkladContext();
            var customerlist = context.Customers.ToList();
            
            return Ok(customerlist);

        }
        

    }
    
}
