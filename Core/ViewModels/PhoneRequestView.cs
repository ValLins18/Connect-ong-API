using Connect_ong_API.Core.Validations;
using Flunt.Notifications;


namespace Connect_ong_API.Core.ViewModels {
    public class PhoneRequestView : Notifiable<Notification> {
        public string PhoneNumber { get; set; }
        public string DDD { get; set; }

        public void Validate() {
            var validation = new PhoneValidation(this);
            AddNotifications(validation);
        }
    }
}
