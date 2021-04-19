using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoItem3
{
        [ApiController]
        [Route("[controller]")]
        
    public class CitiesController : ControllerBase
        {
            public JsonResult GetCities()
            {
            return new JsonResult
             (
                 new List<object>()
                 {
                     new {id = 1, Name = "New York City"},
                     new {id = 2, Name = "Antwerp"}
                 });
            }
        
    }
}
