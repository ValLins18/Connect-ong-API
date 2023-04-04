using AutoMapper;
using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;
using Connect_ong_API.Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Connect_ong_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase {

        private readonly IPhoneRepository _phoneRepository;
        private readonly IMapper _mapper;

        public PhoneController(IPhoneRepository phoneRepository, IMapper mapper) {
            _phoneRepository = phoneRepository;
            _mapper = mapper;
        }


        // GET: api/<PhoneController>
        [HttpGet]
        public async Task<IActionResult> GetAllPhones() {
            return Ok(await _phoneRepository.GetAllPhonesAsync());
        }

        // GET api/<PhoneController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPhoneById(int id) {
            var Phone = await _phoneRepository.GetPhoneByIdAsync(id);
            if(Phone == null) {
                return NotFound();
            }
            return Ok(Phone);
        }

        // POST api/<PhoneController>
        [HttpPost]
        public async Task<IActionResult> CreatePhone([FromBody] PhoneRequestView phoneRequest) {
            phoneRequest.Validate();
            if(!phoneRequest.IsValid) { 
                return BadRequest(phoneRequest.Notifications);
            }
            try {
                Phone phone = _mapper.Map<Phone>(phoneRequest);
                return Created(nameof(AddressController), await _phoneRepository.PostPhoneAsync(phone));
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<PhoneController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePhone(int id, [FromBody] PhoneRequestView phoneRequest) {
            try {
                Phone phone = _mapper.Map<Phone>(phoneRequest);
                await _phoneRepository.PutPhoneAsync(id, phone);
                return NoContent();
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<PhoneController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhone(int id) {
            try {
                await _phoneRepository.DeletePhoneAsync(id);
                return Accepted(new {deleted = true});
            }
            catch (Exception) {
                return BadRequest($"Failed to delete phone: {id}");
            }
        }
    }
}
