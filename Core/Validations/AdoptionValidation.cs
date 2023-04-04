using Connect_ong_API.Core.ViewModels;
using Flunt.Validations;

namespace Connect_ong_API.Core.Validations {
    public class AdoptionValidation : Contract<AdoptionRequestView>{
        public AdoptionValidation(AdoptionRequestView adoptionRequest) {
            Requires()
                .IsNotNullOrEmpty(adoptionRequest.AdoptionDate.ToString(), nameof(adoptionRequest.AdoptionDate))
                .IsGreaterOrEqualsThan(adoptionRequest.AdoptionDate, DateTime.Now, nameof(adoptionRequest.AdoptionDate), "The adoption must be after today")
                .IsNotNullOrEmpty(adoptionRequest.PersonId.ToString(), nameof(adoptionRequest.PersonId))
                .IsGreaterOrEqualsThan(adoptionRequest.PersonId, 1, nameof(adoptionRequest.PersonId))
                .IsNotNullOrEmpty(adoptionRequest.AnimalId.ToString(), nameof(adoptionRequest.AnimalId))
                .IsGreaterOrEqualsThan(adoptionRequest.AnimalId, 1, nameof(adoptionRequest.AnimalId));
        }
    }
}
