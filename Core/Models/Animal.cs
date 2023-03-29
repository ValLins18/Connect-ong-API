namespace Connect_ong_API.Core.Models {
    public class Animal {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string? ImgPath { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public string Specie { get; set; }
        public string Breed { get; set; }
        public DateTime RecueDate { get; set; }
        public bool castred { get; set; }
        public bool available { get; set; }

        public int OngId { get; set; }
        public virtual Ong Ong { get; set; }
    }
}
