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
    public partial class SampleNavigation : ContentPage
    {
        public SampleNavigation()
        {
            InitializeComponent();
        }

        private async void btnListImage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleImageList());
        }

        private async void btnListCustom_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleCustomList());
        }

        private async void menuCal_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Keterangan", "Tombol Call", "OK");
        }

        private async void btnDisplayAlert_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Konfirmasi",
                "Apakah anda confirm untuk mendelete data?", "Yes", "No");
            if (result)
            {
                await DisplayAlert("Keterangan", "Anda menjawab Yes", "OK");
            }
            else
            {
                await DisplayAlert("Keterangan", "Anda menjawab No", "OK");
            }
        }

        private async void btnActionSheet_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Simpan data di?", "Cancel", "Delete",
                "Google Drive", "One Drive", "Drop Box", "Samsung Cloud");
            await DisplayAlert("Keterangan", $"Anda memilih {result}", "OK");
        }

        private async void btnParam_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleParam1());
        }
    }
}