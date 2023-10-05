using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JazaniActividad.Api.Controllers.Generals
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvesmentController : ControllerBase
    {
        // GET: api/<InvesmentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<InvesmentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InvesmentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<InvesmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InvesmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
