using Connect_ong_API.Core.ViewModels;
using Flunt.Validations;

namespace Connect_ong_API.Core.Validations {
    public class PhoneValidation : Contract<PhoneRequestView> {

        public PhoneValidation(PhoneRequestView phone) {
            Requires()
                .IsNotNullOrEmpty(phone.DDD, "DDD", "O DDD do telefone é obrigatorio")
                .IsLowerOrEqualsThan(phone.DDD, 2, "DDD");
        }
    }
}
