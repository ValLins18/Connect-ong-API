using Connect_ong_API.Core.Models;
using Connect_ong_API.Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Connect_ong_API.Data.Repository.Implementation {
    public class PersonRepository : IPersonRepository {

        private readonly AppDbContext _context;
        public PersonRepository(AppDbContext context) {
            _context = context;
        }

        public async Task<Person> DeletePersonAsync(int id) {
            Person person = await GetPersonByIdAsync(id);
            _context.Remove(person);
            _ = await _context.SaveChangesAsync();
            return person;
        }

        public async Task<IEnumerable<Person>> GetAllPersonsAsync() {
            return await _context.Persons
                .Include(p => p.Adress)
                .Include(p => p.Animals)
                .Include(p => p.Phone).ToListAsync();
        }

        public async Task<Person> GetPersonByIdAsync(int id) {
            return await _context.Persons
                .Include(p => p.Adress)
                .Include(p => p.Animals)
                .Include(p => p.Phone).FirstOrDefaultAsync(p => p.PersonId == id);
        }

        public async Task<Person> GetPersonsByCpfCnpjAsync(string cpfCnpj) {
            return await _context.Persons
                .Include(p => p.Adress)
                .Include(p => p.Animals)
                .Include(p => p.Phone).FirstOrDefaultAsync(p => p.CpfCnpj == cpfCnpj);
        }

        public async Task<Person> PostPersonAsync(Person person) {
            _context.Add(person);
            _ = await _context.SaveChangesAsync();
            return person;
        }

        public async Task<Person> PutPersonAsync(Person person) {
            _context.Update(person);
            _ = await _context.SaveChangesAsync();
            return person;
        }
    }
}
