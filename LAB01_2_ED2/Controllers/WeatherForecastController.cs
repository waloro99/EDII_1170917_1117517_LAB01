using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LAB01_2_ED2.Class;
using LAB01_2_ED2.Repository;

namespace LAB01_2_ED2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly ISodasDataBase SDatabase = new SodasDataBase();

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        // localhost:51626/weatherforecast/GetWithParam/?SearchSoda=""
        [HttpGet("GetWithParam", Name = "GetSoda")]
        /*[Route("weatherforecast/Sodas/")]*/
        public IEnumerable<Soda> Get(string SearchSoda)
        {
            if (SearchSoda == null)
            {
                return SDatabase.GetSodas();
            }
            else
            {
                List<Soda> SodaOrden = new List<Soda>(); //new list
                SodaOrden.Add(SDatabase.ReturnMySoda(SearchSoda));
                return SodaOrden;
            }
        }

        [HttpPost]
        public void Post([FromBody]Soda newSoda)
        {
            SDatabase.AddNewSoda(newSoda.Name, newSoda); //method insert
        }
    }
}
