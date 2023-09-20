using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Threading.Tasks;
using Blazored.FluentValidation;
using LeanTask.Application.Features.Brands.Commands.AddEdit;
using LeanTask.Client.Infrastructure.Managers.Catalog.Brand;

namespace LeanTask.Client.Pages.Catalog
{
    public partial class AddEditBrandModal
    {
        [Inject] private IBrandManager BrandManager { get; set; }

        [Parameter] public AddEditBrandCommand AddEditBrandModel { get; set; } = new();
        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }

        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

        public void Cancel()
        {
            MudDialog.Cancel();
        }

        private async Task SaveAsync()
        {
            var response = await BrandManager.SaveAsync(AddEditBrandModel);
            if (response.Succeeded)
            {
                _snackBar.Add(response.Messages[0], Severity.Success);
                MudDialog.Close();
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }

        protected override async Task OnInitializedAsync()
        {
            await LoadDataAsync(); 
        }

        private async Task LoadDataAsync()
        {
            await Task.CompletedTask;
        }
    }
}