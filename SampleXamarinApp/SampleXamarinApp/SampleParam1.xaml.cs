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
    }
}