using AutoMapper;
using LeanTask.Application.Features.Brands.Commands.AddEdit;
using LeanTask.Application.Features.Brands.Queries.GetAll;
using LeanTask.Application.Features.Brands.Queries.GetById;
using LeanTask.Domain.Entities.Catalog;

namespace LeanTask.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}