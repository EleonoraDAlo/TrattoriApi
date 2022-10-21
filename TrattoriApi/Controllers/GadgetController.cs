using Microsoft.AspNetCore.Mvc;
using TrattoriApi.Model;
using TrattoriApi.Service;

namespace TrattoriApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GadgetController : ControllerBase
    {
        private IServiceGadget _serviceGadget;
        public GadgetController(IServiceGadget serviceGadget)
        {
            _serviceGadget = serviceGadget;
        }

        [HttpPost("{trattoreid}")]
        public IActionResult Post(int trattoreid, [FromBody] Gadget gadget)
        {
            return Ok(_serviceGadget.Insert(trattoreid, gadget));
        }

    }
}
