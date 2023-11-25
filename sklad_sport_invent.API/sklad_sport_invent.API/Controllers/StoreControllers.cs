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


  
            var storelist = context1.Stores.ToList();

            return Ok(storelist);

        }
        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var storelist = context1.Stores.FirstOrDefault(x => x.Id == id);
            return Ok(storelist);
        }

    }

}
