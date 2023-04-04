using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;

namespace Connect_ong_API.Data.Repository.Interface {
    public interface IAnimalRepository {
        Task<Animal> GetAnimalByIdAsync(int id);
        Task<IEnumerable<Animal>> GetAllAnimalsAsync();
        Task<IEnumerable<Animal>> GetAnimalsByCpfCnpjAsync(string cpfCnpj);
        Task<Animal> PostAnimalAsync(Animal animal);
        Task<Animal> PutAnimalAsync(int id, Animal animal);
        Task<Animal> DeleteAnimalAsync(int id);

    }
}
