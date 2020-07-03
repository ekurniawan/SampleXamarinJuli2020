using SampleXamarinApp.DAL;
using SampleXamarinApp.Models;
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
    public partial class ShowEmployee : ContentPage
    {
        private DataAccess _dataAccess;
        public ShowEmployee()
        {
            InitializeComponent();
            _dataAccess = new DataAccess();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lvData.ItemsSource = _dataAccess.GetAllEmployee();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployee());
        }

        private async void lvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var editData = (Employee)e.Item;
            EditEmployee frmEditEmployee = new EditEmployee();
            frmEditEmployee.BindingContext = editData;
            await Navigation.PushAsync(frmEditEmployee);
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtSearch.Text.Length >= 4)
            {
                lvData.ItemsSource = _dataAccess.GetAllEmpByName(txtSearch.Text);
            }
        }
    }
}