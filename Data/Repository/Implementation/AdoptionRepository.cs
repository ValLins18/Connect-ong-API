using AutoMapper;
using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;
using Connect_ong_API.Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Connect_ong_API.Data.Repository.Implementation {
    public class AdoptionRepository : IAdoptionRepository {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AdoptionRepository(AppDbContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Adoption> DeleteAdoptionAsync(int id) {
            Adoption adoption = await GetAdoptionByIdAsync(id);
            _context.Remove(adoption);
            await _context.SaveChangesAsync();
            return adoption;
        }

        public async Task<Adoption> GetAdoptionByIdAsync(int id) {
            return await _context.Adoptions.FirstOrDefaultAsync(ad => ad.AdoptionId == id);
        }

        public async Task<IEnumerable<Adoption>> GetAllAdoptionsAsync() {
            return await _context.Adoptions.ToListAsync();
        }

        public async Task<Adoption> PostAdoptionAsync(Adoption adoption) {
            _context.Add(adoption);
            await _context.SaveChangesAsync();
            return adoption;
        }

        public async Task<Adoption> PutAdoptionAsync(int id, Adoption adoption) {
            _context.Update(adoption);
            adoption.AdoptionId = id;
            await _context.SaveChangesAsync();
            return adoption;
        }
    }
}
