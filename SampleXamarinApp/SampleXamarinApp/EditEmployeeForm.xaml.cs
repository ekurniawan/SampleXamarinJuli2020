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
    public partial class EditEmployeeForm : ContentPage
    {
        private EmployeeService empService;
        public EditEmployeeForm()
        {
            InitializeComponent();
            empService = new EmployeeService();
        }

        private async void btnEdit_Clicked(object sender, EventArgs e)
        {
            var editEmp = new Employee
            {
                EmpId = Convert.ToInt32(txtEmpID.Text),
                EmpName = txtEmpName.Text,
                Designation = txtDesignation.Text,
                Department = txtDepartment.Text,
                Qualification = txtQualification.Text
            };
            try
            {
                await empService.Edit(editEmp);
                await DisplayAlert("Keterangan", "Data berhasil diedit","OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}