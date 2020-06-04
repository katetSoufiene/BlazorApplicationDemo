using Blazor.Models;
using BlazorServer.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorServer.Pages
{
    public class DisplayEmployeeBase : ComponentBase
    {
        [Parameter]
        public Employee Employee { get; set; }
     

        [Parameter]
        public EventCallback<int> OnEmployeeDeleted { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected Blazor.Components.ConfirmBase DeleteConfirmation { get; set; } 

        protected void Delete_Click()
        {
            DeleteConfirmation.Show();
        }

        protected async Task ConfirmDelete_Click(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await EmployeeService.DeleteEmployee(Employee.Id);
                await OnEmployeeDeleted.InvokeAsync(Employee.Id);
            }
        }
    }
}
