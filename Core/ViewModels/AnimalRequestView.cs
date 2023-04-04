using Connect_ong_API.Core.Validations;
using Flunt.Notifications;

namespace Connect_ong_API.Core.ViewModels {
    public class AnimalRequestView : Notifiable<Notification>{
        public string Name { get; set; }
        public string? ImgPath { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public string Breed { get; set; }
        public string Specie { get; set; }
        public DateTime RescueDate { get; set; }
        public bool Castred { get; set; }
        public bool Available { get; set; }
        public int PersonId { get; set; }

        public void Validate() {
            var validation = new AnimalValidation(this);
            AddNotifications(validation);
        }
    }
}
