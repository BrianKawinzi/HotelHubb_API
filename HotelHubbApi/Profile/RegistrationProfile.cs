using AutoMapper;
using fixit.DTO;
using fixit.Models;

namespace fixit.Profiles
{
    public class RegistrationProfile : Profile
    {
        public class RegistrationProfile()
        {
            CreateMap<fixit.Models.Registration, RegistrationDto>()
            
        }
    }
}