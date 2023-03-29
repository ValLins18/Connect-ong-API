using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;
using Connect_ong_API.Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Connect_ong_API.Data.Repository.Implementation {
    public class AddressRepository : IAddressRepository {

        private readonly AppDbContext _context;

        public AddressRepository(AppDbContext context) {
            _context = context;
        }

        public async Task<Address> DeleteAddressAsync(int id) {
            Address address = await GetAddressByIdAsync(id);
            _context.Remove(address);
            _context.SaveChanges();
            return address;
        }

        public async Task<Address> GetAddressByIdAsync(int id) {
            return await _context.Addresses.FirstOrDefaultAsync(a => a.AddressId == id);
        }

        public async Task<IEnumerable<Address>> GetAllAddressesAsync() {
            return await _context.Addresses.ToListAsync();
        }

        public async Task<AddressPostView> PostAdressAsync(AddressPostView address) {
            Address address1 = new Address {
                Street = address.Street,
                City = address.City,
                Neighborhood = address.Neighborhood,
                Number = address.Number,
                State = address.State,
                ZipCode = address.ZipCode
            };
            _ = await _context.AddAsync(address1);
            _ = await _context.SaveChangesAsync();
            return address;
        }

        public async Task<AddressPutView> PutAddressAsync(int id, AddressPutView address) {
            Address address1 = new Address {
                AddressId= id,
                Street = address.Street,
                City = address.City,
                ZipCode = address.ZipCode,
                State = address.State,
                Neighborhood = address.Neighborhood,
                Number = address.Number
            };
            _context.Addresses.Update(address1);
            await _context.SaveChangesAsync();
            return address;
        }

    }
}
