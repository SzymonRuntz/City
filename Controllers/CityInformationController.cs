using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace city.Controllers
{
    [ApiController]
    [Route("api/cities/{Id}/citiesInfo")]
    public class CityInformationController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetCitiesInfo(int Id)
        {
            var cityId = Baza.current.City.FirstOrDefault(c => c.id == Id);

            if (cityId == null)
            {
                return NotFound();
            }
            return Ok(cityId.CityInfo);
        }
         [HttpGet("{InfoId}")]

         public IActionResult GetCityInfo( int Id, int InfoId)
        {
            var cityId = Baza.current.City.FirstOrDefault(c => c.id == Id);

            if (cityId == null)
            {
                return NotFound();
            }

            var cityInfoId = cityId.CityInfo.FirstOrDefault(c => c.id == InfoId);

            if (cityInfoId == null)
            {
                return NotFound();
            }

            return Ok(cityInfoId);
        }

    }
}
