using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.Data;
using Final.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Final.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamesController : ControllerBase
    {       
        private readonly ILogger<GamesController> _logger;
        //private readonly ProjectContext _context;
        private readonly IProjectContext2 _context;
        
        public GamesController(ILogger<GamesController> logger, IProjectContext2 context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() //IEnumerable<WeatherForecast> Get()
        {            
            //return Ok(_context.Names.ToList()); 
            return Ok(_context.GetAllGames());            
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var game = _context.GetGameById(id);
            if (game == null)
                return NotFound(id);

            return Ok(game);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            //var name = _context.RemoveNameById(id);
            var result = _context.RemoveGameById(id);

            //if (name == null)
            if (result == null)
                return NotFound(id);
            //if (string.IsNullOrEmpty(name.FullName))
            if (result == 0)
                return StatusCode(500, "Error processing request");
            
            return Ok();          
        }
        [HttpPut]
        public IActionResult Put(TeamGame game)
        {
           var result = _context.updateGame(game);
           if (result == null)
               return NotFound(game.TeamGameId);

            if (result == 0)
                return StatusCode(500, "Error processing request");
            
            return Ok();           
        }
        [HttpPost]
        public IActionResult Post(TeamGame game)
        {
            var result = _context.Add(game);
            if (result == null)
               return StatusCode(500, "Game already exists");

            if (result == 0)
                return StatusCode(500, "Error processing request");
            
            return Ok();            
        }
      
    }
}