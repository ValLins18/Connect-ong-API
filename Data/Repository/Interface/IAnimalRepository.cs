using Connect_ong_API.Core.Models;

namespace Connect_ong_API.Data.Repository.Interface {
    public interface IAnimalRepository {
        Task<Animal> GetAnimalByIdAsync(int id);
        Task<IEnumerable<Animal>> GetAllAnimalsAsync();
        Task<Animal> PostAnimalAsync(Animal animal);
        Task<Animal> PutAnimalAsync(Animal animal);
        Task<Animal> DeleteAnimalAsync(int id);

    }
}
