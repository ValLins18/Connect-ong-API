using System.ComponentModel.DataAnnotations;

namespace Connect_ong_API.Core.Models {
    public class Adoption {
        public int AdoptionId { get; set; }
        public DateTime AdoptionDate { get; set;}
        public int AnimalId { get; set; }
        public virtual Animal Animal { get; set; }

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }


    }
}
