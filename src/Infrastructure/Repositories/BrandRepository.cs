using LeanTask.Application.Interfaces.Repositories;
using LeanTask.Domain.Entities.Catalog;

namespace LeanTask.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}