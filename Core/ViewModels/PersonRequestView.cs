using Connect_ong_API.Core.Models;

namespace Connect_ong_API.Core.ViewModels {
    public class PersonRequestView {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string CpfCnpj { get; set; }
        public string? ImgPath { get; set; }
        public string PersonType { get; set; }
        public string Email { get; set; }
        public Phone Phone { get; set; }
        public Address Adress { get; set; }

    }
}
