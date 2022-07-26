﻿using System;
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
    public class hobbiesController : ControllerBase
    {       
        private readonly ILogger<hobbiesController> _logger;
        //private readonly ProjectContext _context;
        private readonly IProjectContext2 _context;

        //public hobbiesController(ILogger<hobbiesController> logger, ProjectContext context)
        public hobbiesController(ILogger<hobbiesController> logger, IProjectContext2 context)        
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() //IEnumerable<WeatherForecast> Get()
        {            
            //return Ok(_context.Hobbies.ToList()); 
            return Ok(_context.GetAllHobbies());           
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var hobby = _context.GetHobbyById(id);
            if (hobby == null)
                return NotFound(id);

            return Ok(hobby);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            //var name = _context.RemoveNameById(id);
            var result = _context.RemoveHobbyById(id);

            //if (name == null)
            if (result == null)
                return NotFound(id);
            //if (string.IsNullOrEmpty(name.FullName))
            if (result == 0)
                return StatusCode(500, "Error processing request");
            
            return Ok();          
        }
        [HttpPut]
        public IActionResult Put(TeamHobby hobby)
        {
           var result = _context.updateHobby(hobby);
           if (result == null)
               return NotFound(hobby.TeamHobbyId);

            if (result == 0)
                return StatusCode(500, "Error processing request");
            
            return Ok();           
        }
        [HttpPost]
        public IActionResult Post(TeamHobby hobby)
        {
            var result = _context.Add(hobby);
            if (result == null)
               return StatusCode(500, "Hobby already exists");

            if (result == 0)
                return StatusCode(500, "Error processing request");
            
            return Ok();            
        }
      
    }
}
