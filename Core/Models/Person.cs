namespace Connect_ong_API.Core.Models {
    public class Person {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string CpfCnpj { get; set; }
        public string? ImgPath { get; set;}
        public string PersonType { get; set; }
        public string Email { get; set; }

        public int AdressId { get; set; }
        public virtual Address Adress { get; set; }

        public int PhoneId { get; set; }
        public virtual Phone Phone { get; set; }

        public IList<Animal>? Animals { get; set; }
    }
}
