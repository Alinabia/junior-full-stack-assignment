using AutoMapper;
using LeanTask.Application.Requests.Identity;
using LeanTask.Application.Responses.Identity;

namespace LeanTask.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}