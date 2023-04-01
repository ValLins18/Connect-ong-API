using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;
using Connect_ong_API.Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Connect_ong_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class DonateController : ControllerBase {

        private readonly IDonateRepository _donateRepository;

        public DonateController(IDonateRepository donateRepository) {
            _donateRepository = donateRepository;
        }

        // GET: api/<DonateController>
        [HttpGet]
        public async Task<IActionResult> GetAllDonates() {
            return Ok(await _donateRepository.GetAllDonatesAsync());
        }

        // GET api/<DonateController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDonateById(int id) {
            Donate donate = await _donateRepository.GetDonateByIdAsync(id);
            if(donate == null) {
                return NotFound();
            }
            return Ok(donate);
        }

        // POST api/<DonateController>
        [HttpPost]
        public async Task<IActionResult> CreateDonate([FromBody] DonateRequestView donateRequest) {
            if(donateRequest == null) {
                return BadRequest();
            }
            try {
                await _donateRepository.PostDonateAsync(donateRequest);
                return Created("", donateRequest);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        // PUT api/<DonateController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDonate(int id, DonateRequestView donateRequest) {
            if (donateRequest == null) {
                return BadRequest();
            }
            try {
                await _donateRepository.PutDonateAsync(id, donateRequest);
                return NoContent();
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/<DonateController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonate(int id) {
            Donate donate = await _donateRepository.GetDonateByIdAsync(id);
            if (donate == null) {
                return NotFound();
            }
            try {
                await _donateRepository.DeleteDonateAsync(id);
                return Accepted(new {deleted = true});
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}
