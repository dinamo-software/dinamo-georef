using DS.GeoRef.DataStore.Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DS.GeoRef.Controllers.ApiSurface
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciaController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public IActionResult Get([FromServices] IConfiguration coniguration)
        {
            try
            {
                var connectionString = coniguration.GetConnectionString("GeoRef");
                var repo = new ProvinciaDapperRepository(connectionString);

                var result = new List<dynamic>();
                repo.AllKeys().ForEach(key => result.Add(repo.Get(key)));

                return Ok(result.Select(x=>new { x.code, x.name }));

            }
            catch (Exception ex)
            {
                //Logger.Error(ex);
                throw new ApplicationException("error generando la lista de provincias", ex);
            }
        }

        // GET api/<ProvinciasController>/5
        [HttpGet("{code}")]
        public string Get(string code)
        {
            return "value" + code.ToString();
        }
    }
}
