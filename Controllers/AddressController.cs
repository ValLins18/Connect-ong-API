using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;
using Connect_ong_API.Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Connect_ong_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase {

        private readonly IAddressRepository _addressRepository;

        public AddressController(IAddressRepository addressRepository) {
            _addressRepository = addressRepository;
        }


        // GET: api/<AddressController>
        [HttpGet]
        public async Task<IActionResult> GetAddressById() {
            return Ok(await _addressRepository.GetAllAddressesAsync());
        }

        // GET api/<AddressController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddressById(int id) {
            Address address = await _addressRepository.GetAddressByIdAsync(id);
            if (address == null) {
                return NotFound(new { Message = "Endereço não encontrado" });
            }
            return Ok(address);
        }

        // POST api/<AddressController>
        [HttpPost]
        public async Task<IActionResult> CreateAdress([FromBody] AddressPostView address) {
            await _addressRepository.PostAdressAsync(address);
            return Created(nameof(AddressController), address);
        }

        // PUT api/<AddressController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAdress(int id, [FromBody] AddressPutView addressPut) {
            try {
                await _addressRepository.PutAddressAsync(id, addressPut);
                return NoContent();
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<AddressController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdress(int id) {
            try {
                await _addressRepository.DeleteAddressAsync(id); return Accepted(new {Deleted = true});
            }
            catch (Exception e) {
                return BadRequest("Não foi possivel encontrar o endereço");
            }
        }
    }
}
