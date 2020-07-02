using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleXamarinApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //global
            Application.Current.Properties["username"] = "";

            MainPage = new MyMasterPage();
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
