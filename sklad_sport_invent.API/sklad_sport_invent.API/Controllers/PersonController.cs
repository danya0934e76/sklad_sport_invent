using Microsoft.AspNetCore.Mvc;

namespace sklad_sport_invent.API.Controllers
{
    [ApiController]
    [Route("controllers")]


public class PersonController : ControllerBase 
    {
        [HttpGet] //localhost:111224/group 
        public IActionResult actionResult()
        {
            var context = new sklad_sport_inventContext() as IContext;
            var Store = context.Store.ToList(); 
            return Ok(Store);

        }
        

    }
    
}
