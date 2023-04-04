using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;

namespace Connect_ong_API.Data.Repository.Interface {
    public interface IDonateRepository {
        Task<Donate> GetDonateByIdAsync(int id);
        Task<IEnumerable<Donate>> GetAllDonatesAsync();
        Task<Donate> PostDonateAsync(Donate donate);
        Task<Donate> PutDonateAsync(int id, Donate donate);
        Task<Donate> DeleteDonateAsync(int id);
    }
}
