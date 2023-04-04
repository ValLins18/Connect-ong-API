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

        public async Task<Address> PostAdressAsync(Address address) {
            await _context.AddAsync(address);
            await _context.SaveChangesAsync();
            return address;
        }

        public async Task<Address> PutAddressAsync(int id, Address address) {
            address.AddressId = id;
            _context.Addresses.Update(address);
            await _context.SaveChangesAsync();
            return address;
        }

    }
}
