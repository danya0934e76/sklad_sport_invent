using Microsoft.AspNetCore.Mvc;
using sklad_sport_invent.Context;
using sklad_sport_invent.Context.Contacts;

namespace sklad_sport_invent.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
public class CustomerController : ControllerBase 
    {
        private readonly IContext context1;
        public CustomerController (IContext context1)
        {
            this.context1 = context1;
        }

        [HttpGet] //localhost:111224/group 
        public IActionResult GetAllCustomers ()
        {

            var customerlist = context1.Customers.ToList();
            
            return Ok(customerlist);

        }
        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var customerlist = context1.Customers.FirstOrDefault(x=> x.Id == id);
            return Ok(customerlist);
        }
        [HttpPost]
        public IActionResult Post(Customer model)
        {
         var item = new Customer
        {  
             Id = Guid.NewGuid(),
             Name = model.Name,
            Address= model.Address,
              CreatedAt= DateTime.UtcNow,
              CreatedBy= "ya",
              UpDatedAt= DateTime.UtcNow,
              UpDatedBy = "ya",


         };
            context1.Customers.Add(item);   
            return Ok(item);
        }
        [HttpDelete("{id}")]
        public IActionResult actionResultDelete(Guid id) 
        {
            var customer12 = context1.Customers.FirstOrDefault(x=> x.Id == id);
            if (customer12 != null) 
            {
                context1.Customers.Remove(customer12);
            }
            return Ok();
        }

    }
    
}
