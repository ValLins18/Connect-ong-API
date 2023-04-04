using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.Validations;
using Flunt.Notifications;

namespace Connect_ong_API.Core.ViewModels {
    public class AdoptionRequestView : Notifiable<Notification>{

        public DateTime AdoptionDate { get; set; }
        public int AnimalId { get; set; }
        public int PersonId { get; set; }

        public void Validate() {
            var validation = new AdoptionValidation(this);
            AddNotifications(validation);
        }
    }
}
