using Microsoft.AspNetCore.Mvc;
using sklad_sport_invent.Context;
using sklad_sport_invent.Context.Contacts;

namespace sklad_sport_invent.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NakladnayaController : ControllerBase

    {
        private readonly IContext context1;
        public NakladnayaController(IContext context1)
        {
            this.context1 = context1;
        }

        [HttpGet] //localhost:111224/group 
        public IActionResult GetAllNakladnaya()
        {

          
            var nakladnayalist = context1.Nakladnaya.ToList();

            return Ok(nakladnayalist);

        }
        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var nakladnayalist = context1.Nakladnaya.FirstOrDefault(x => x.Id == id);
            return Ok(nakladnayalist);
        }

    }

}
