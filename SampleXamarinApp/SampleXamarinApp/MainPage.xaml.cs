using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleXamarinApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //btnSubmit.Clicked += btnSubmit_Clicked;
        }

        private void btnSubmit_Clicked(object sender, EventArgs e)
        {
            var firstname = entryUsername.Text;
            var lastname = "Kurniawan";
            lblResult.Text = "Nama anda : " + firstname + " " + lastname ;
            DisplayAlert("Keterangan", $"Nama anda: {firstname} {lastname}", "OK");
        }
    }
}
