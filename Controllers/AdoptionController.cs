using AutoMapper;
using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;
using Connect_ong_API.Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Connect_ong_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AdoptionController : ControllerBase {

        private readonly IAdoptionRepository _adoptionRepository;
        private readonly IMapper _mapper;

        public AdoptionController(IAdoptionRepository adoptionRepository, IMapper mapper) {
            _adoptionRepository = adoptionRepository;
            _mapper = mapper;
        }


        // GET: api/<AdoptionController>
        [HttpGet]
        public async Task<IActionResult> GetAllAdoptions() {
            return Ok(await _adoptionRepository.GetAllAdoptionsAsync());
        }

        // GET api/<AdoptionController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdoptionById(int id) {
            Adoption adoption = await _adoptionRepository.GetAdoptionByIdAsync(id);
            if (adoption == null) {
                return NotFound("Adoção inexistente");
            }
            return Ok(adoption);
        }

        // POST api/<AdoptionController>
        [HttpPost]
        public async Task<IActionResult> CreateAdoption([FromBody] AdoptionRequestView adoptionRequest) {
            adoptionRequest.Validate();
            if (!adoptionRequest.IsValid) {
                return BadRequest(adoptionRequest.Notifications);
            }
            try {
                Adoption adoption = _mapper.Map<Adoption>(adoptionRequest);
                await _adoptionRepository.PostAdoptionAsync(adoption);
                return Created(nameof(AdoptionController), adoption);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        // PUT api/<AdoptionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAdoption(int id, [FromBody] AdoptionRequestView adoptionRequest) {
            adoptionRequest.Validate();
            if (!adoptionRequest.IsValid) {
                return BadRequest(adoptionRequest.Notifications);
            }
            try {
                Adoption adoption = _mapper.Map<Adoption>(adoptionRequest);
                await _adoptionRepository.PutAdoptionAsync(id, adoption);
                return NoContent();
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/<AdoptionController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdoption(int id) {
            Adoption adoption = await _adoptionRepository.GetAdoptionByIdAsync(id);
            if (adoption == null) {
                return NotFound("Adoção inexistente");
            }
            try {
                await _adoptionRepository.DeleteAdoptionAsync(id);
                return Accepted(new { Deleted = true });
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}
