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
    public class StateController : Controller
    {
        private readonly ILogger<StateController> _logger;
        private readonly IConfiguration _configuration;
        public StateController(ILogger<StateController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var connectionString = _configuration.GetConnectionString("GeoRef");
            var repo = new ProvinciaDapperRepository(connectionString);
            var result = repo.All();
            return View(result);
        }

    }
}
