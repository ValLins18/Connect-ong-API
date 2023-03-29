namespace Connect_ong_API.Core.Models {
    public class Donate {
        public int DonateId { get; set; }
        public DateTime DonateDate { get; set; }
        public decimal Value { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
