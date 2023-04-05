using Connect_ong_API.Core.ViewModels;
using Flunt.Validations;

namespace Connect_ong_API.Core.Validations {
    public class PersonValidation : Contract<PersonRequestView>{

        public PersonValidation(PersonRequestView personRequest) {
            Requires()
                .IsNotNullOrEmpty(personRequest.Name, nameof(personRequest.Name))
                .IsNotNullOrEmpty(personRequest.CpfCnpj, nameof(personRequest.CpfCnpj))
                .IsNotNullOrEmpty(personRequest.PersonType, nameof(personRequest.PersonType))
                .IsNotNullOrEmpty(personRequest.Email, nameof(personRequest.Email))
                .IsNotNullOrEmpty(personRequest.Gender, nameof(personRequest.Gender))
                .IsNotNullOrEmpty(personRequest.BirthDate.ToString(), nameof(personRequest.BirthDate))
                .IsLowerOrEqualsThan(personRequest.BirthDate, DateTime.Now, nameof(personRequest.BirthDate), "The birthDate must be before today")
                .IsEmail(personRequest.Email, nameof(personRequest.Email), "Email is invalid")
                .Matches(personRequest.PersonType, "^[FJ]$", nameof(personRequest.PersonType), "PersonType must be F or J")
                .Matches(personRequest.Gender, "^[FM]$", nameof(personRequest.Gender), "Gender must be M or F")
                .IsNotNull(personRequest.Address, nameof(personRequest.Address))
                .IsNotNull(personRequest.Phone, nameof(personRequest.Phone));
        }
    }
}
