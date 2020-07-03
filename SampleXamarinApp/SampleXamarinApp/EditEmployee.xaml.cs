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
    public partial class EditEmployee : ContentPage
    {
        private DataAccess _dataAccess;
        public EditEmployee()
        {
            InitializeComponent();
            _dataAccess = new DataAccess();
        }

        private async void btnEdit_Clicked(object sender, EventArgs e)
        {
            var editEmp = new Employee
            {
                EmpId = Convert.ToInt32(txtEmpID.Text),
                EmpName = txtEmpName.Text,
                Department = txtDepartment.Text,
                Designation = txtDesignation.Text,
                Qualification = txtQualification.Text
            };

            try
            {
                _dataAccess.EditEmployee(editEmp);
                await DisplayAlert("Keterangan", "Data berhasil diedit", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btnDelete_Clicked(object sender, EventArgs e)
        {
            var deleteEmp = new Employee
            {
                EmpId = Convert.ToInt32(txtEmpID.Text)
            };
            try
            {
                var result = await DisplayAlert("Konfirmasi", 
                    "Apakah anda akan delete data?", "Yes", "No");
                if (result)
                {
                    _dataAccess.DeleteEmployee(deleteEmp);
                    await DisplayAlert("Keterangan", "Data berhasil di delete", "OK");
                    await Navigation.PopAsync();
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Kesalahan", ex.Message, "OK");
            }
        }
    }
}