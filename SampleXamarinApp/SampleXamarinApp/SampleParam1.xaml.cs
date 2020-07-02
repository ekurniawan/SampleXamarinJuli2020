using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace SampleXamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleParam1 : ContentPage
    {
        public SampleParam1()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Clicked(object sender, EventArgs e)
        {
            var param = txtData.Text;
            await Navigation.PushAsync(new SampleParam2(param, "parameter 2"));
        }

        private async void btnAppCurrent_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["username"] = txtData.Text;
            await Navigation.PushAsync(new SampleParam2());
        }

        private async void btnPreference_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("username", txtData.Text);
            await DisplayAlert("Keterangan", "Preferences berhasil dibuat", "OK");
        }

        private async void btnGetPreference_Clicked(object sender, EventArgs e)
        {
            var data = Preferences.Get("username", "");
            await DisplayAlert("Keterangan", $"Data:{data}", "OK");
        }
    }
}