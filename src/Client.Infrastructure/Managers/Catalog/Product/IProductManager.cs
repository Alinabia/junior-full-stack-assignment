using LeanTask.Application.Features.Products.Commands.AddEdit;
using LeanTask.Application.Features.Products.Queries.GetAllPaged;
using LeanTask.Application.Requests.Catalog;
using LeanTask.Shared.Wrapper;
using System.Threading.Tasks;

namespace LeanTask.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}