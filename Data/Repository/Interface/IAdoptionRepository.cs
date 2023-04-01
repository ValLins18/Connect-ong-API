using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;

namespace Connect_ong_API.Data.Repository.Interface {
    public interface IAdoptionRepository {
        Task<Adoption> GetAdoptionByIdAsync(int id);
        Task<IEnumerable<Adoption>> GetAllAdoptionsAsync();
        Task<AdoptionRequestView> PostAdoptionAsync(AdoptionRequestView adoptionRequest);
        Task<AdoptionRequestView> PutAdoptionAsync(int id, AdoptionRequestView adoptionRequest);
        Task<Adoption> DeleteAdoptionAsync(int id);
    }
}
