using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CountriesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private ILogger _logger;

        public CountriesController(ILogger<CountriesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "India", "China" };
        }
        ///Get: api/countries/india
        [HttpGet("{country}")]
        public IEnumerable<string> Get(string country)
        {
            if (country.ToLower() == "india")
                return new string[] { "Karnataka", "Andhra Pradesh" };
            else
                return new string[] { "Work in progress.." };
        }
    }
}
