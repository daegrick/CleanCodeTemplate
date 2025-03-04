using AutoMapper;
using CleanCode.Application.Features.Users;
using CleanCode.Domain.Entities;

namespace CleanCode.Application.Features.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserVm>().ReverseMap();
        }
    }
}
