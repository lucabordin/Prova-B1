using Microsoft.AspNetCore.Mvc;
using WebAPIMongoDB.Entities;
using WebAPIMongoDB.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MongoController : ControllerBase
    {
        private IMongoService _service;
        public MongoController(IMongoService service)
            => _service = service;
        // GET: api/<MongoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MongoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Carrello>>> Get(int id)
        {
            return await _service.GetCarrello(id);
        }

        // POST api/<MongoController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Carrello carrello)
        {
            await _service.AddCarrello(carrello);
            return Ok();
        }

        // PUT api/<MongoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MongoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
