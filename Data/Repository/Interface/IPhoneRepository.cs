using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;

namespace Connect_ong_API.Data.Repository.Interface {
    public interface IPhoneRepository {
        Task<Phone> GetPhoneByIdAsync(int id);
        Task<IEnumerable<Phone>> GetAllPhonesAsync();
        Task<Phone> PostPhoneAsync(Phone phone);
        Task<Phone> PutPhoneAsync(int id, Phone phone);
        Task<Phone> DeletePhoneAsync(int id);
    }
}
