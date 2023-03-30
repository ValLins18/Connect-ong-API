﻿using AutoMapper;
using Connect_ong_API.Core.Models;
using Connect_ong_API.Core.ViewModels;

namespace Connect_ong_API.Core.MapConfiguration {
    public class MapConfig {
        public MapConfig() { }

        public static MapperConfiguration RegisterMaps() {
            var mappingConfig = new MapperConfiguration(c => {
                c.CreateMap<PersonRequestView, Person>();
                c.CreateMap<Person, PersonRequestView> ();
            });
            return mappingConfig;
        }
    }
}
