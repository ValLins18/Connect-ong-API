using AutoMapper;
using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;
using Connect_ong_API.Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Connect_ong_API.Data.Repository.Implementation {
    public class AnimalRepository : IAnimalRepository {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AnimalRepository(AppDbContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Animal> DeleteAnimalAsync(int id) {
            Animal animal = await GetAnimalByIdAsync(id);
            _context.Remove(animal);
            await _context.SaveChangesAsync();
            return animal;
        }

        public async Task<IEnumerable<Animal>> GetAllAnimalsAsync() {
            return await _context.Animals.
                Include(a => a.Ong).ToListAsync();
        }

        public async Task<Animal> GetAnimalByIdAsync(int id) {
            return await _context.Animals.FirstOrDefaultAsync(a => a.AnimalId == id);
        }

        public async Task<IEnumerable<Animal>> GetAnimalsByCpfCnpjAsync(string cpfCnpj) {
            IList<Animal>? animals = await _context.Animals
                .Include(a => a.Ong)
                .Where(a => a.Ong.CpfCnpj.Equals(cpfCnpj)).ToListAsync();
            return animals;
        }

        public async Task<AnimalRequestView> PostAnimalAsync(AnimalRequestView animalRequest) {
            Animal animal = _mapper.Map<Animal>(animalRequest);
            _context.Add(animal);
            await _context.SaveChangesAsync();
            return animalRequest;
        }

        public async Task<AnimalRequestView> PutAnimalAsync(int id, AnimalRequestView animalRequest) {
            Animal animal = _mapper.Map<Animal>(animalRequest);
            animal.AnimalId= id;
            _context.Update(animal);
            await _context.SaveChangesAsync();
            return animalRequest;
        }
    }
}
