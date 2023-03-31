using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;
using Connect_ong_API.Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Connect_ong_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]

    public class AnimalController : ControllerBase {

        private readonly IAnimalRepository _animalRepository;
        public AnimalController(IAnimalRepository animalRepository) {
            _animalRepository = animalRepository;
        }

        // GET: api/<AnimalController>
        [HttpGet]
        public async Task<IActionResult> GetAllAnimals() {
            return Ok(await _animalRepository.GetAllAnimalsAsync());
        }

        // GET api/<AnimalController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAnimalById(int id) {
            Animal animal = await _animalRepository.GetAnimalByIdAsync(id);
            if(animal == null) {
                return NotFound();
            }
            return Ok(animal);
        }

        [HttpGet("OngAnimals/{cpf}")]
        public async Task<IActionResult> GetAnimalsByCpfPerson(string cpf) {
            IEnumerable<Animal> animals = await _animalRepository.GetAnimalsByCpfCnpjAsync(cpf);
            if (!animals.Any()) {
                return NotFound("Não foi encontrado nenhum animal cadastrado nesse CpfCnpj");
            }
            return Ok(animals);
        }

        // POST api/<AnimalController>
        [HttpPost]
        public async Task<IActionResult> CreateAnimal([FromBody] AnimalRequestView animalRequest) {
            if(animalRequest == null) {
                return BadRequest();
            }
            try {
                await _animalRepository.PostAnimalAsync(animalRequest);
                return Created("", animalRequest);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        // PUT api/<AnimalController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] AnimalRequestView animalRequest) {
            if (animalRequest == null) {
                return BadRequest();
            }
            try {
                await _animalRepository.PutAnimalAsync(id, animalRequest);
                return NoContent();
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/<AnimalController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            Animal animal = await _animalRepository.GetAnimalByIdAsync(id);
            if (animal == null) {
                return NotFound("O animal com id "+id+" não existe");
            }
            try {
                await _animalRepository.DeleteAnimalAsync(id);
                return Accepted(new {deleted = true});
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}
