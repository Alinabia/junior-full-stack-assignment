﻿using LeanTask.Application.Interfaces.Repositories;
using LeanTask.Application.Interfaces.Services.Identity;
using LeanTask.Domain.Entities.Catalog;
using LeanTask.Shared.Wrapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks; 
using Microsoft.Extensions.Localization;

namespace LeanTask.Application.Features.Dashboards.Queries.GetData
{
    public class GetDashboardDataQuery : IRequest<Result<DashboardDataResponse>>
    {

    }

    internal class GetDashboardDataQueryHandler : IRequestHandler<GetDashboardDataQuery, Result<DashboardDataResponse>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IStringLocalizer<GetDashboardDataQueryHandler> _localizer;

        public GetDashboardDataQueryHandler(IUnitOfWork<int> unitOfWork, IUserService userService, IRoleService roleService, IStringLocalizer<GetDashboardDataQueryHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _userService = userService;
            _roleService = roleService;
            _localizer = localizer;
        }

        public async Task<Result<DashboardDataResponse>> Handle(GetDashboardDataQuery query, CancellationToken cancellationToken)
        {
            var response = new DashboardDataResponse
            {
                UserCount = await _userService.GetCountAsync(),
                RoleCount = await _roleService.GetCountAsync()
            };

            var selectedYear = DateTime.Now.Year;
            double[] productsFigure = new double[13];
            double[] brandsFigure = new double[13];
            for (int i = 1; i <= 12; i++)
            {
                var month = i;
                var filterStartDate = new DateTime(selectedYear, month, 01);
                var filterEndDate = new DateTime(selectedYear, month, DateTime.DaysInMonth(selectedYear, month), 23, 59, 59);  

                productsFigure[i - 1] = await _unitOfWork.Repository<Product>().Entities.Where(x => x.CreatedOn >= filterStartDate && x.CreatedOn <= filterEndDate).CountAsync(cancellationToken);
                brandsFigure[i - 1] = await _unitOfWork.Repository<Brand>().Entities.Where(x => x.CreatedOn >= filterStartDate && x.CreatedOn <= filterEndDate).CountAsync(cancellationToken);
            }

            response.DataEnterBarChart.Add(new ChartSeries { Name = _localizer["Products"], Data = productsFigure });
            response.DataEnterBarChart.Add(new ChartSeries { Name = _localizer["Brands"], Data = brandsFigure });

            return await Result<DashboardDataResponse>.SuccessAsync(response);
        }
    }
}