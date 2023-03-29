using Connect_ong_API.Core.Models;

namespace Connect_ong_API.Data.Repository.Interface {
    public interface IAddressRepository {

        Task<Address> GetAddressByIdAsync(int id);
        Task<IEnumerable<Address>> GetAllAddressesAsync();
        Task<Address> PostAdressAsync(Address address);
        Task<Address> PutAddressAsync(Address address);
        Task<Address> DeleteAddressAsync(int id);
    }
}
