using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LAB01_2_ED2.Class;

namespace LAB01_2_ED2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        BTree<String, Soda> Tree5 = new BTree<String, Soda>(5); //instance class btree

        [HttpGet("GetWithParam", Name = "GetUser")]
        public ActionResult<Soda> Get(string SearchSoda)
        {
            if (SearchSoda == null)
            {
                List<Soda> SodaOrden = new List<Soda>();
                // SodaOrden = Tree5.InOrden(ref SodaOrden);
                foreach (Soda item in SodaOrden)
                {
                    return item;
                }

            }
            return null;
        }

        [HttpPost]
        public void Post([FromBody]Soda newSoda)
        {           
            Tree5.Insert(newSoda.Name, newSoda); //method insert
        }
    }
}
