﻿namespace Connect_ong_API.Core.Models {
    public class Address {

        public int AddressId { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}
