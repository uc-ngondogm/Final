using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Final.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteGameController : ControllerBase
    {
        private readonly ILogger<FavoriteGameController> _logger;
        //private readonly ProjectContext _context;
        private readonly IProjectContext2 _context;

        //public hobbiesController(ILogger<hobbiesController> logger, ProjectContext context)
        public FavoriteGameController(ILogger<FavoriteGameController> logger, IProjectContext2 context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() //IEnumerable<WeatherForecast> Get()
        {
            //return Ok(_context.Hobbies.ToList()); 
            return Ok(_context.GetAllGames());
        }
    }
}
