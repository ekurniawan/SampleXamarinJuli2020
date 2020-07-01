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
    public partial class BindingListPage : ContentPage
    {
        public BindingListPage()
        {
            InitializeComponent();
            List<ListItem> lstItems = new List<ListItem>();
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Android",
                Description = "Belajar Xamarin for Android"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin IOS",
                Description = "Belajar Xamarin for IOS"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Forms",
                Description = "Belajar Xamarin Forms"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Forms 1",
                Description = "Belajar Xamarin Forms 1"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Forms 2",
                Description = "Belajar Xamarin Forms 2"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Forms",
                Description = "Belajar Xamarin Forms"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Forms",
                Description = "Belajar Xamarin Forms"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Forms",
                Description = "Belajar Xamarin Forms"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Forms",
                Description = "Belajar Xamarin Forms"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Forms",
                Description = "Belajar Xamarin Forms"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Forms",
                Description = "Belajar Xamarin Forms"
            });


            lvItem.ItemsSource = lstItems;
        }

        private void lvItem_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectData = (ListItem)e.Item;
            DisplayAlert("Keterangan", 
                $"Title: {selectData.Title} Desc: {selectData.Description}", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}