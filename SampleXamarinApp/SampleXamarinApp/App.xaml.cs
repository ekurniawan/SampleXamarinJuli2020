using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleXamarinApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new SampleFlexLayout();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
