using DS.GeoRef.DataStore.Dapper;
using DS.GeoRef.DataStore.Entities;
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
    public class MunicipioController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public IActionResult Get([FromServices] IConfiguration coniguration)
        {
            try
            {
                var connectionString = coniguration.GetConnectionString("GeoRef");
                var repo = new MunicipioDapperRepository(connectionString);

                var result = new List<dynamic>();
                repo.AllKeys().ForEach(key => result.Add(repo.Get(key)));

                return Ok(result.Select(x=>new { x.code, x.name }));

            }
            catch (Exception ex)
            {
                //Logger.Error(ex);
                throw new ApplicationException("error generando la lista de municipios", ex);
            }
        }

        [HttpGet]
        [Route("amba")]
        public IActionResult GetAmba(
            [FromServices] IConfiguration coniguration,
            [FromQuery] string zona_code,
            [FromQuery] string cordon_code
            )
        {
            try
            {
                var result = new List<MunicipioEntity>();
                var connectionString = coniguration.GetConnectionString("GeoRef");
                var repoAmba = new MunicipioAmbaDapperRepository(connectionString);

                var amba = new List<MunicipioAmbaEntity>();
                foreach (var k in repoAmba.AllKeys())
                {
                    amba.Add(repoAmba.Get(k));
                }

                if (!string.IsNullOrEmpty(zona_code)) //tengo que filtrar por zona
                {
                    var aux = new List<MunicipioAmbaEntity>();
                    foreach (var a in amba)
                    {
                        if (a.zona_code == zona_code)
                        {
                            aux.Add(a);
                        }
                    }
                    amba = aux;
                }

                if (!string.IsNullOrEmpty(cordon_code)) //tengo que filtrar por cordon
                {
                    var aux = new List<MunicipioAmbaEntity>();
                    foreach (var a in amba)
                    {
                        if (a.cordon_code == cordon_code)
                        {
                            aux.Add(a);
                        }
                    }
                    amba = aux;
                }

                var repoMunicipio = new MunicipioDapperRepository(connectionString);
                foreach (var a in amba)
                {
                    result.Add(repoMunicipio.Get(a.municipio_code));
                }

                return Ok(result.Select(x => new { x.code, x.name })); 
            }
            catch (Exception ex)
            {
                //Logger.Error(ex);
                throw new ApplicationException("error generando la lista de municipios de amba", ex);
            }
        }

        [HttpGet]
        [Route("glp")]
        public IActionResult GetGlp([FromServices] IConfiguration coniguration)
        {
            try
            {
                var connectionString = coniguration.GetConnectionString("GeoRef");
                var repo = new MunicipioDapperRepository(connectionString);

                var result = new List<MunicipioEntity>();

                foreach (var k in repo.AllGlpKeys())
                {
                    var m = repo.Get(k);
                    result.Add(m);
                }

                return Ok(result.Select(x => new { x.code, x.name }));
            }
            catch (Exception ex)
            {
                //Logger.Error(ex);
                throw new ApplicationException("error generando la lista de municipios", ex);
            }
        }

        // GET api/<MunicipiosController>/5
        [HttpGet("{code}")]
        public string Get(string code)
        {
            return "value" + code.ToString();
        }

    }
}
