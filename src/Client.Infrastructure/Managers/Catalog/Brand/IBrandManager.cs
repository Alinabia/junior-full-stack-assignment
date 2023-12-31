﻿using LeanTask.Application.Features.Brands.Queries.GetAll;
using LeanTask.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeanTask.Application.Features.Brands.Commands.AddEdit;

namespace LeanTask.Client.Infrastructure.Managers.Catalog.Brand
{
    public interface IBrandManager : IManager
    {
        Task<IResult<List<GetAllBrandsResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditBrandCommand request);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}