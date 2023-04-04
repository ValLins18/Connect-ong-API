using Connect_ong_API.Core.ViewModels;
using Flunt.Validations;

namespace Connect_ong_API.Core.Validations {
    public class AddressValidation : Contract<AddressRequestView>{

        public AddressValidation(AddressRequestView addressRequest) {
            Requires()
                .IsNotNullOrEmpty(addressRequest.Number, nameof(addressRequest.Number))
                .IsNotNullOrEmpty(addressRequest.Street, nameof(addressRequest.Street))
                .IsNotNullOrEmpty(addressRequest.State, nameof(addressRequest.State))
                .IsNotNullOrEmpty(addressRequest.City, nameof(addressRequest.City))
                .IsNotNullOrEmpty(addressRequest.Neighborhood, nameof(addressRequest.Neighborhood))
                .IsNotNullOrEmpty(addressRequest.ZipCode, nameof(addressRequest.ZipCode))
                .Matches(addressRequest.ZipCode, "^\\d{8}$", nameof(addressRequest.ZipCode), "O CEP deve ser numerico e conter 8 digitos");
        }
    }
}
