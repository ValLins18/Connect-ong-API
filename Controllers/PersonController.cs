using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;
using Connect_ong_API.Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Connect_ong_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase {

        private readonly IPersonRepository _personRepository;
        public PersonController(IPersonRepository personRepository) {
            _personRepository = personRepository;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<IActionResult> GetAllPerson() {
            return Ok(await _personRepository.GetAllPersonsAsync());
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonById(int id) {
            Person person = await _personRepository.GetPersonByIdAsync(id);
            if (person == null) {
                return NotFound();
            }
            return Ok(person);
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<IActionResult> CreatePerson([FromBody] PersonRequestView personRequest) {
            if (personRequest == null) {
                return BadRequest();
            }
            try {
                _ = await _personRepository.PostPersonAsync(personRequest);
                return Created("", personRequest);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePerson(int id, [FromBody] PersonRequestView personRequest) {
            if (personRequest == null) {
                return BadRequest();
            }
            try {
                await _personRepository.PutPersonAsync(id, personRequest);
                return NoContent();
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(int id) {
            Person person = _personRepository.GetPersonByIdAsync(id).Result;
            if (person == null) {
                return NotFound();
            }
            try {
                _ = _personRepository.DeletePersonAsync(id);
                return Accepted(new { deleted = true });
            }
            catch (Exception) {
                return BadRequest($"Unable to delete person {id}");
            }
        }
    }
}
