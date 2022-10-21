using Microsoft.AspNetCore.Mvc;
using TrattoriApi.Model;
using TrattoriApi.Service;

namespace TrattoriApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TrattoreController : ControllerBase
    {
        private IServiceTrattore _serviceTrattore;

        public TrattoreController(IServiceTrattore serviceTrattore)
        {
            _serviceTrattore = serviceTrattore;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PostTrattoreModel trattore)
        {
           try
            {
                return Created($"{nameof(GetDetail)}", _serviceTrattore.Insert(trattore));
            }
            catch(ArgumentException e)
            {
                return BadRequest(e.Message);
            }
                    
        }

        [HttpGet("{id}")]
        public IActionResult GetDetail(int id)
        {
            try
            {
               return Ok(_serviceTrattore.GetDetail(id));
            }
            catch(ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet("filterby/{color}")]
        public IActionResult GetAllByFilter(string color)
        {
            return Ok(_serviceTrattore.GetAllByFilter(color));
        }


        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Trattore trattore, int id)
        {
            return Ok(_serviceTrattore.Update(trattore, id));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           _serviceTrattore.Delete(id);
            return Ok();
        }
        [HttpGet("searchbygadget/{gadgetid}")]
        public IActionResult SearchBy(int gadgetid)
        {
            return  Ok(_serviceTrattore.SearchByGadget(gadgetid));
        }

        [HttpGet("orderbygadgets/")]
        public IActionResult OrderBy()
        {
            return Ok(_serviceTrattore.OrderByNumberOfGadgets());

        }


    }
}
