using AutoMapper;
using LeanTask.Application.Requests.Identity;
using LeanTask.Application.Responses.Identity;
using LeanTask.Infrastructure.Models.Identity;

namespace LeanTask.Infrastructure.Mappings
{
    public class RoleClaimProfile : Profile
    {
        public RoleClaimProfile()
        {
            CreateMap<RoleClaimResponse, LeanRoleClaim>()
                .ForMember(nameof(LeanRoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(LeanRoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();

            CreateMap<RoleClaimRequest, LeanRoleClaim>()
                .ForMember(nameof(LeanRoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(LeanRoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();
        }
    }
}