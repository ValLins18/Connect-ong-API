using Connect_ong_API.Core.Validations;
using Flunt.Notifications;
using System.Globalization;

namespace Connect_ong_API.Core.ViewModels {
    public class AddressRequestView : Notifiable<Notification>{
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public void Validate() {
            var validation = new AddressValidation(this);
            AddNotifications(validation);
        }

    }
}
