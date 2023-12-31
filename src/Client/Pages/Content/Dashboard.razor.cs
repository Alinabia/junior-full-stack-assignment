﻿using System;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using LeanTask.Client.Infrastructure.Managers.Dashboard;

namespace LeanTask.Client.Pages.Content
{
    public partial class Dashboard
    {
        [Inject] private IDashboardManager DashboardManager { get; set; }

        [Parameter] public int UserCount { get; set; }
        [Parameter] public int RoleCount { get; set; }

        private readonly string[] _dataEnterBarChartXAxisLabels = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        private readonly List<ChartSeries> _dataEnterBarChartSeries = new();
        private bool _loaded;

        protected override async Task OnInitializedAsync()
        {
            await LoadDataAsync();
            _loaded = true;
        }

        private async Task LoadDataAsync()
        {
            var response = await DashboardManager.GetDataAsync();
            if (response.Succeeded)
            {
                UserCount = response.Data.UserCount;
                RoleCount = response.Data.RoleCount;
                foreach (var item in response.Data.DataEnterBarChart)
                {
                    _dataEnterBarChartSeries
                        .RemoveAll(x => x.Name.Equals(item.Name, StringComparison.OrdinalIgnoreCase));
                    _dataEnterBarChartSeries.Add(new ChartSeries { Name = item.Name, Data = item.Data });
                }
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }
    }
}