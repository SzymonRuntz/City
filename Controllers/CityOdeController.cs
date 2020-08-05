using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace city.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CityOdeController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetCities()
        {
            return Ok(Baza.current.City);
        }
        [HttpGet ("{Id}")]

        public IActionResult GetCity(int Id)
        {
            var cityId = Baza.current.City.FirstOrDefault(c => c.id == Id);
            
            if (cityId == null)
            {
                return NotFound();
            }
            return Ok(cityId);
        }

    }
}
