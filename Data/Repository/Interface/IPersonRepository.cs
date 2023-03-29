using Connect_ong_API.Core.Models;

namespace Connect_ong_API.Data.Repository.Interface {
    public interface IPersonRepository {
        Task<Person> GetPersonByIdAsync(int id);
        Task<Person> GetPersonsByCpfCnpjAsync(string cpfCnpj);
        Task<IEnumerable<Person>> GetAllPersonsAsync();
        Task<Person> PostPersonAsync(Person person);
        Task<Person> PutPersonAsync(Person person);
        Task<Person> DeletePersonAsync(int id);

    }
}
