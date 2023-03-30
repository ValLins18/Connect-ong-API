using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;

namespace Connect_ong_API.Data.Repository.Interface {
    public interface IPhoneRepository {
        Task<Phone> GetPhoneByIdAsync(int id);
        Task<IEnumerable<Phone>> GetAllPhonesAsync();
        Task<PhoneRequestView> PostPhoneAsync(PhoneRequestView phoneRequest);
        Task<PhoneRequestView> PutPhoneAsync(int id, PhoneRequestView phoneRequest);
        Task<Phone> DeletePhoneAsync(int id);
    }
}
