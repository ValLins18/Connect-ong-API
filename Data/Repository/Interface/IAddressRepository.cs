using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;

namespace Connect_ong_API.Data.Repository.Interface {
    public interface IAddressRepository {

        public Task<Address> GetAddressByIdAsync(int id);
        public Task<IEnumerable<Address>> GetAllAddressesAsync();
        public Task<AddressPostView> PostAdressAsync(AddressPostView address);
        public Task<AddressPutView> PutAddressAsync(int id, AddressPutView address);
        public Task<Address> DeleteAddressAsync(int id);
    }
}
