using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KubeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockForecastController : ControllerBase
    {
        private static readonly double[] Summaries = new[]
        {
            33.44, 68.6, 23.55, 43.5, 235.3, 32.55, 23.6, 44.4, 356.49, 23.5
        };

        private readonly ILogger<StockForecastController> _logger;

        public StockForecastController(ILogger<StockForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<StockForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 10).Select(index => new StockForecast
            {
                Date = DateTime.Now.AddDays(index),
                Change = rng.Next(-20, 55),
                Value = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
