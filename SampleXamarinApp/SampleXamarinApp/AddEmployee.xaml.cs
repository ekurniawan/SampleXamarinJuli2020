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
    public partial class AddEmployee : ContentPage
    {
        private DataAccess _dataAccess;
        public AddEmployee()
        {
            InitializeComponent();
            _dataAccess = new DataAccess();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            var newEmployee = new Employee
            {
                EmpName = txtEmpName.Text,
                Designation = txtDesignation.Text,
                Department = txtDepartment.Text,
                Qualification = txtQualification.Text
            };
            try
            {
                _dataAccess.InsertEmployee(newEmployee);
                await DisplayAlert("Keterangan",
                    $"Data Employee {newEmployee.EmpName} berhasil ditambah", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}