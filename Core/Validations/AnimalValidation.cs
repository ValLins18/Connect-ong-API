using Connect_ong_API.Core.ViewModels;
using Flunt.Validations;

namespace Connect_ong_API.Core.Validations {
    public class AnimalValidation : Contract<AnimalRequestView> {
        public AnimalValidation(AnimalRequestView animalRequest) {
            Requires()
                .IsNotNullOrEmpty(animalRequest.Name, nameof(animalRequest.Name))
                .IsNotNullOrEmpty(animalRequest.Specie, nameof(animalRequest.Specie))
                .IsNotNullOrEmpty(animalRequest.Gender, nameof(animalRequest.Gender))
                .Matches(animalRequest.Gender, "^[FM]$", nameof(animalRequest.Gender), "Gender must be F or M")
                .IsNotNullOrEmpty(animalRequest.Breed, nameof(animalRequest.Breed))
                .IsNotNullOrEmpty(animalRequest.RescueDate.ToString(), nameof(animalRequest.RescueDate))
                .IsLowerOrEqualsThan(animalRequest.RescueDate, DateTime.Now, nameof(animalRequest.RescueDate))
                .IsGreaterOrEqualsThan(animalRequest.PersonId, 1, nameof(animalRequest.PersonId));
        }
    }
}
