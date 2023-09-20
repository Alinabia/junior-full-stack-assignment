using AutoMapper;
using LeanTask.Application.Features.Products.Commands.AddEdit;
using LeanTask.Domain.Entities.Catalog;

namespace LeanTask.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}