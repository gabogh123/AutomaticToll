using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutomaticTollAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverCarController : ControllerBase
    {
        // GET: api/<DriverCarController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DriverCarController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DriverCarController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DriverCarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DriverCarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
