using AutoMapper;
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
        private readonly IMapper _mapper;
        public PersonController(IPersonRepository personRepository, IMapper mapper) {
            _personRepository = personRepository;
            _mapper = mapper;
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

        [HttpGet("cpfcnpj/{cpfcnpj}")]
        public async Task<IActionResult> GetPersonByCpfCnpj(string cpfcnpj) {
            Person person = await _personRepository.GetPersonsByCpfCnpjAsync(cpfcnpj);
            if (person == null) {
                return NotFound();
            }
            return Ok(person);
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<IActionResult> CreatePerson([FromBody] PersonRequestView personRequest) {
            personRequest.Validate();
            if (!personRequest.IsValid) {
                return BadRequest(personRequest.Notifications);
            }
            try {                
                Person person = _mapper.Map<Person>(personRequest);
                return Created("", await _personRepository.PostPersonAsync(person));
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePerson(int id, [FromBody] PersonRequestView personRequest) {
            personRequest.Validate();
            if (!personRequest.IsValid) {
                return BadRequest(personRequest.Notifications);
            }
            try {
                Person person = _mapper.Map<Person>(personRequest);
                await _personRepository.PutPersonAsync(id, person);
                return NoContent();
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(int id) {
            Person person = await _personRepository.GetPersonByIdAsync(id);
            if (person == null) {
                return NotFound();
            }
            try {
                _ = await _personRepository.DeletePersonAsync(id);
                return Accepted(new { deleted = true });
            }
            catch (Exception) {
                return BadRequest($"Unable to delete person {id}");
            }
        }
    }
}
