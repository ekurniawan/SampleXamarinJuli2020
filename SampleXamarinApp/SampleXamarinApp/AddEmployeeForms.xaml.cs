using SampleXamarinApp.Models;
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
    public partial class AddEmployeeForms : ContentPage
    {
        private EmployeeService empServices;
        public AddEmployeeForms()
        {
            InitializeComponent();
            empServices = new EmployeeService();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            var newEmp = new Employee
            {
                EmpName = txtEmpName.Text,
                Department = txtDepartment.Text,
                Designation = txtDesignation.Text,
                Qualification = txtQualification.Text
            };
            try
            {
                await empServices.Insert(newEmp);
                await DisplayAlert("Konfirmasi",
                    $"Employee {newEmp.EmpName} berhasil ditambah", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}