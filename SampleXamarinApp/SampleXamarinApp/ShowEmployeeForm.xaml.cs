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
    }
}