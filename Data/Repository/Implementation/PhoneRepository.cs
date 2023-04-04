using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;
using Connect_ong_API.Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Connect_ong_API.Data.Repository.Implementation {
    public class PhoneRepository : IPhoneRepository {
        private readonly AppDbContext _context;

        public PhoneRepository(AppDbContext context) {
            _context = context;
        }

        public async Task<Phone> DeletePhoneAsync(int id) {
            Phone Phone = await GetPhoneByIdAsync(id);
            _context.Remove(Phone);
            _context.SaveChanges();
            return Phone;
        }

        public async Task<Phone> GetPhoneByIdAsync(int id) {
            return await _context.Phones.FirstOrDefaultAsync(a => a.PhoneId == id);
        }

        public async Task<IEnumerable<Phone>> GetAllPhonesAsync() {
            return await _context.Phones.ToListAsync();
        }

        public async Task<Phone> PostPhoneAsync(Phone phone) {
            await _context.AddAsync(phone);
            _context.SaveChanges();
            return phone;
        }

        public async Task<Phone> PutPhoneAsync(int id, Phone phone) {
            phone.PhoneId = id;
            _context.Phones.Update(phone);
            await _context.SaveChangesAsync();
            return phone;
        }
    }
}