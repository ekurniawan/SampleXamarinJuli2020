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
    public partial class SampleCustomList : ContentPage
    {
        public SampleCustomList()
        {
            InitializeComponent();
            List<ListItem> lstItems = new List<ListItem>();
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Android",
                Description = "Belajar Xamarin for Android",
                Source = "monkey.png",
                Price = 10000
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin IOS",
                Description = "Belajar Xamarin for IOS",
                Source = "monkey2.png",
                Price = 20000
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Forms",
                Description = "Belajar Xamarin Forms",
                Source = "monkey3.png",
                Price=30000
            });
            lvData.ItemsSource = lstItems;
        }

        private async void OnEdit(object sender, EventArgs e)
        {
            var editBtn = (Button)sender;
            await DisplayAlert("Keterangan", editBtn.CommandParameter.ToString(), "OK");
        }

        private async void OnDelete(object sender, EventArgs e)
        {
            var deleteBtn = (Button)sender;
            await DisplayAlert("Keterangan", deleteBtn.CommandParameter.ToString(), "OK");
        }
    }
}