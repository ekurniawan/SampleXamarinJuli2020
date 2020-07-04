using SampleXamarinApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleXamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowEmployeeForm : ContentPage
    {
        private EmployeeService empService;
        public ShowEmployeeForm()
        {
            InitializeComponent();
            empService = new EmployeeService();
        }

        protected async override void OnAppearing()
        {
            var results = await empService.GetAll();
            lvData.ItemsSource = results;
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployeeForms());
        }

        private async void lvData_Refreshing(object sender, EventArgs e)
        {
            var results = await empService.GetAll();
            lvData.ItemsSource = results;
            lvData.IsRefreshing = false;
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var data = (MenuItem)sender;
            await DisplayAlert("Keterangan", 
                $"EmpId: {data.CommandParameter} akan dihapus", "OK");
        }
    }
}