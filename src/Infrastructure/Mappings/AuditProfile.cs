using AutoMapper;
using LeanTask.Infrastructure.Models.Audit;
using LeanTask.Application.Responses.Audit;

namespace LeanTask.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}