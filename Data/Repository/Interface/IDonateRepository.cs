using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;

namespace Connect_ong_API.Data.Repository.Interface {
    public interface IDonateRepository {
        Task<Donate> GetDonateByIdAsync(int id);
        Task<IEnumerable<Donate>> GetAllDonatesAsync();
        Task<DonateRequestView> PostDonateAsync(DonateRequestView donateRequest);
        Task<DonateRequestView> PutDonateAsync(int id, DonateRequestView donateRequest);
        Task<Donate> DeleteDonateAsync(int id);
    }
}
