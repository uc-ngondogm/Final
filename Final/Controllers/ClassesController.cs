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
    public class ClassesController : ControllerBase
    {       
        private readonly ILogger<ClassesController> _logger;
        //private readonly ProjectContext _context;
        private readonly IProjectContext2 _context;

        //public ClassesController(ILogger<ClassesController> logger, ProjectContext context)
        public ClassesController(ILogger<ClassesController> logger, IProjectContext2 context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() //IEnumerable<WeatherForecast> Get()
        {            
            //return Ok(_context.Names.ToList()); 
            return Ok(_context.GetAllClasses());            
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var class1 = _context.GetClassById(id);
            if (class1 == null)
                return NotFound(id);

            return Ok(class1);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            //var name = _context.RemoveNameById(id);
            var result = _context.RemoveClassById(id);

            //if (name == null)
            if (result == null)
                return NotFound(id);
            //if (string.IsNullOrEmpty(name.FullName))
            if (result == 0)
                return StatusCode(500, "Error processing request");
            
            return Ok();          
        }
        [HttpPut]
        public IActionResult Put(TeamClass class1)
        {
           var result = _context.updateClass(class1);
           if (result == null)
               return NotFound(class1.TeamClassId);

            if (result == 0)
                return StatusCode(500, "Error processing request");
            
            return Ok();           
        }
        [HttpPost]
        public IActionResult Post(TeamClass class1)
        {
            var result = _context.Add(class1);
            if (result == null)
               return StatusCode(500, "Class already exists");

            if (result == 0)
                return StatusCode(500, "Error processing request");
            
            return Ok();            
        }
      
    }
}