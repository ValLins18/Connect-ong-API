using System.Text.Json.Serialization;

namespace Connect_ong_API.Core.Models {
    public class Animal {
        public int AnimalId { get; set; }
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

        [JsonIgnore]
        public virtual Person Ong { get; set; }
    }
}
