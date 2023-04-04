using Connect_ong_API.Core.Validations;
using Flunt.Notifications;

namespace Connect_ong_API.Core.ViewModels {
    public class DonateRequestView : Notifiable<Notification>{
        public DateTime DonateDate { get; set; }
        public decimal value { get; set; }
        public int PersonId { get; set; }

        public void Validate() {
            var validation = new DonateValidation(this);
            AddNotifications(validation);
        }
    }
}
