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
    public class NamesController : ControllerBase
    {       
        private readonly ILogger<NamesController> _logger;
        //private readonly ProjectContext _context;
        private readonly IProjectContext2 _context;

        //public NamesController(ILogger<NamesController> logger, ProjectContext context)
        public NamesController(ILogger<NamesController> logger, IProjectContext2 context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() //IEnumerable<WeatherForecast> Get()
        {            
            //return Ok(_context.Names.ToList()); 
            return Ok(_context.GetAllNames());            
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var name = _context.GetNameById(id);
            if (name == null)
                return NotFound(id);

            return Ok(name);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            //var name = _context.RemoveNameById(id);
            var result = _context.RemoveNameById(id);

            //if (name == null)
            if (result == null)
                return NotFound(id);
            //if (string.IsNullOrEmpty(name.FullName))
            if (result == 0)
                return StatusCode(500, "Error processing request");
            
            return Ok();          
        }
        [HttpPut]
        public IActionResult Put(TeamName name)
        {
           var result = _context.updateName(name);
           if (result == null)
               return NotFound(name.TeamNameId);

            if (result == 0)
                return StatusCode(500, "Error processing request");
            
            return Ok();           
        }
        [HttpPost]
        public IActionResult Post(TeamName name)
        {
            var result = _context.Add(name);
            if (result == null)
               return StatusCode(500, "Name already exists");

            if (result == 0)
                return StatusCode(500, "Error processing request");
            
            return Ok();            
        }
      
    }
}