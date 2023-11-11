using Microsoft.AspNetCore.Mvc;
using sklad_sport_invent.Context;

namespace sklad_sport_invent.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NakladnayaController : ControllerBase
    {
        [HttpGet] //localhost:111224/group 
        public IActionResult GetAllNakladnaya()
        {

            var context = new SkladContext();
            var nakladnayalist = context.Nakladnaya.ToList();

            return Ok(nakladnayalist);

        }


    }

}
