using AutoMapper;
using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;

namespace Connect_ong_API.Core.MapConfiguration {
    public class MapConfig {
        public MapConfig() { }

        public static MapperConfiguration RegisterMaps() {
            var mappingConfig = new MapperConfiguration(c => {
                c.CreateMap<PersonRequestView, Person>();
                c.CreateMap<Person, PersonRequestView> ();

                c.CreateMap<Animal, AnimalRequestView>();
                c.CreateMap<AnimalRequestView, Animal> ();

                c.CreateMap<Donate, DonateRequestView>();
                c.CreateMap<DonateRequestView, Donate>();

                c.CreateMap<Adoption, AdoptionRequestView>();
                c.CreateMap<AdoptionRequestView, Adoption>();

                c.CreateMap<Phone, PhoneRequestView>();
                c.CreateMap<PhoneRequestView, Phone>();

                c.CreateMap<Address, AddressRequestView>();
                c.CreateMap<AddressRequestView, Address>();
            });
            return mappingConfig;
        }
    }
}
