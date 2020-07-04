﻿using SampleXamarinApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
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

        private async Task GetData()
        {
            var current = Connectivity.NetworkAccess;
            if (current != NetworkAccess.Internet || 
                current == NetworkAccess.ConstrainedInternet)
            {
                await DisplayAlert("Keterangan", "Tidak ada koneksi internet", "OK");
            }
            else
            {
                var results = await empService.GetAll();
                lvData.ItemsSource = results;
            }
        }

        protected async override void OnAppearing()
        {
            await GetData();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployeeForms());
        }

        private async void lvData_Refreshing(object sender, EventArgs e)
        {
            await GetData();
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