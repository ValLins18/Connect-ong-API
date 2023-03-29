using Connect_ong_API.Core.Models;

namespace Connect_ong_API.Data.Repository.Interface {
    public interface IPhoneRepository {
        Task<Phone> GetPhoneByIdAsync(int id);
        Task<IEnumerable<Phone>> GetAllPhonesAsync();
        Task<Phone> PostPhoneAsync(Phone Phone);
        Task<Phone> PutPhoneAsync(Phone Phone);
        Task<Phone> DeletePhoneAsync(int id);
    }
}
