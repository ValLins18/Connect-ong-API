using AutoMapper;
using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;
using Connect_ong_API.Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Connect_ong_API.Data.Repository.Implementation {
    public class DonateRepository : IDonateRepository {

        AppDbContext _context;
        IMapper _mapper;

        public DonateRepository(AppDbContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Donate> DeleteDonateAsync(int id) {
            Donate donate = await GetDonateByIdAsync(id);
            _context.Remove(donate);
            await _context.SaveChangesAsync();
            return donate;
        }

        public async Task<IEnumerable<Donate>> GetAllDonatesAsync() {
            return await _context.Donates.ToListAsync();
        }

        public async Task<Donate> GetDonateByIdAsync(int id) {
            return await _context.Donates.FirstOrDefaultAsync(d => d.DonateId == id);
        }

        public async Task<DonateRequestView> PostDonateAsync(DonateRequestView donateRequest) {
            Donate donate = _mapper.Map<Donate>(donateRequest);
            _context.Add(donate);
            await _context.SaveChangesAsync();
            return donateRequest;
        }

        public async Task<DonateRequestView> PutDonateAsync(int id, DonateRequestView donateRequest) {
            Donate donate = _mapper.Map<Donate>(donateRequest);
            donate.DonateId = id;
            _context.Update(donate);
            await _context.SaveChangesAsync();
            return donateRequest;
        }
    }
}
