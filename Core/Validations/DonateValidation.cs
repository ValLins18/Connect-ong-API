using Connect_ong_API.Core.ViewModels;
using Flunt.Validations;

namespace Connect_ong_API.Core.Validations {
    public class DonateValidation : Contract<DonateRequestView> {
        public DonateValidation(DonateRequestView donateRequest) {
            Requires()
                .IsNotNullOrEmpty(donateRequest.DonateDate.ToString(), nameof(donateRequest.DonateDate))
                .IsNotNullOrEmpty(donateRequest.value.ToString(), nameof(donateRequest.value))
                .IsGreaterOrEqualsThan(donateRequest.value, 0.5, nameof(donateRequest.PersonId), "The minimum donate value its $0,50")
                .IsNotNullOrEmpty(donateRequest.PersonId.ToString(), nameof(donateRequest.PersonId))
                .IsGreaterOrEqualsThan(donateRequest.PersonId, 1, nameof(donateRequest.PersonId));              
        }
    }
}
