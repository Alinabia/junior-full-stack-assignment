using AutoMapper;
using LeanTask.Infrastructure.Models.Identity;
using LeanTask.Application.Responses.Identity;

namespace LeanTask.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, LeanRole>().ReverseMap();
        }
    }
}