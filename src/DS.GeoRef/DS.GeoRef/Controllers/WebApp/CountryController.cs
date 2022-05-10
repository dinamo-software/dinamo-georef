using DS.GeoRef.DataStore.Dapper;
using DS.GeoRef.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DS.GeoRef.Controllers
{
    public class CountryController : Controller
    {
        private readonly ILogger<CountryController> _logger;
        private readonly IConfiguration _configuration;
        public CountryController(ILogger<CountryController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var connectionString = _configuration.GetConnectionString("GeoRef");
            var repo = new CountryDapperRepository(connectionString);
            var result = repo.All(); // ¿Como hago para enviar mas de un result distinto a la vista? por ejemplo
                                                 // lista de paises y municipios
            return View(result);
        }
        
    }
}
