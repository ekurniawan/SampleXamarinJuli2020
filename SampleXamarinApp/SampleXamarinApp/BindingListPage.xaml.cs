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

            lvItem.ItemsSource = lstItems;
        }
    }
}