using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;

namespace Connect_ong_API.Data.Repository.Interface {
    public interface IPersonRepository {
        Task<Person> GetPersonByIdAsync(int id);
        Task<Person> GetPersonsByCpfCnpjAsync(string cpfCnpj);
        Task<IEnumerable<Person>> GetAllPersonsAsync();
        Task<PersonRequestView> PostPersonAsync(PersonRequestView personRequest);
        Task<PersonRequestView> PutPersonAsync(int id, PersonRequestView personRequest);
        Task<Person> DeletePersonAsync(int id);

    }
}
