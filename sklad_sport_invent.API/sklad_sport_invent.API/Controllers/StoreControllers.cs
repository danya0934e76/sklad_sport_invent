using Microsoft.AspNetCore.Mvc;
using sklad_sport_invent.Context;

namespace sklad_sport_invent.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        [HttpGet] //localhost:111224/group 
        public IActionResult GetAllStore()
        {

            var context = new SkladContext();
            var storelist = context.Stores.ToList();

            return Ok(storelist);

        }


    }

}
