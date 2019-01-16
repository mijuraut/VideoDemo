using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VideoDemo.Controllers
{
    [Route("toiminnot/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET toiminnot/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET toiminnot/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST toiminnot/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT toiminnot/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE toiminnot/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
