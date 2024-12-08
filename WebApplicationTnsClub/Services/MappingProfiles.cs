using AutoMapper;
using System.Net;


using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Services
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // CreateMap<Address, AddressDto>();
          //anna  CreateMap<UserForRegistrationDto, User>()
          //     .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
