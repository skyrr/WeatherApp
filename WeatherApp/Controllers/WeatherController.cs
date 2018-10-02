using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeatherApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Weather")]
    public class WeatherController : Controller
    {
        // GET api/values/5
        [HttpGet("forecast/{city}")]
        public IActionResult Forecast(string city)
        {
            var weather = city;
            return Json(weather);
        }

    }
}