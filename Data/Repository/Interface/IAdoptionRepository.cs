using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;

namespace Connect_ong_API.Data.Repository.Interface {
    public interface IAdoptionRepository {
        Task<Adoption> GetAdoptionByIdAsync(int id);
        Task<IEnumerable<Adoption>> GetAllAdoptionsAsync();
        Task<Adoption> PostAdoptionAsync(Adoption adoption);
        Task<Adoption> PutAdoptionAsync(int id, Adoption adoption);
        Task<Adoption> DeleteAdoptionAsync(int id);
    }
}
