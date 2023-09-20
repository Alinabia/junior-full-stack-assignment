using AutoMapper;
using LeanTask.Infrastructure.Models.Identity;
using LeanTask.Application.Responses.Identity;

namespace LeanTask.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, LeanUser>().ReverseMap();
        }
    }
}