using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.Validations;
using Flunt.Notifications;

namespace Connect_ong_API.Core.ViewModels {
    public class PersonRequestView : Notifiable<Notification>{
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string CpfCnpj { get; set; }
        public string? ImgPath { get; set; }
        public string PersonType { get; set; }
        public string Email { get; set; }
        public PhoneRequestView Phone { get; set; }
        public AddressRequestView Address{ get; set; }

        public void Validate() {
            ValidatePerson();
            if (Phone != null) Phone.Validate();
            if (Address != null) Address.Validate();
            Notifications.Concat(Phone.Notifications).Concat(Address.Notifications).ToList();
        }
        private void ValidatePerson() {
            var validations = new PersonValidation(this);
            AddNotifications(validations);
        }

    }
}
