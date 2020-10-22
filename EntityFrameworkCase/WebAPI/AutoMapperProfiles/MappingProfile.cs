using AutoMapper;
using EntityFrameworkCase.Domain.DataTransferObjects;
using EntityFrameworkCase.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCase.WebAPI.AutoMapperProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonDto>();
            CreateMap<PersonDto, Person>();

            CreateMap<FirstName, FirstNameDto>();
            CreateMap<FirstNameDto, FirstName>();            
            
            CreateMap<Surname, SurnameDto>();
            CreateMap<SurnameDto, Surname>();

            CreateMap<City, CityDto>();
            CreateMap<CityDto, City>();

            CreateMap<Street, StreetDto>();
            CreateMap<StreetDto, Street>();

            CreateMap<Workplace, WorkplaceDto>();
            CreateMap<WorkplaceDto, Workplace>();
        }
    }
}
