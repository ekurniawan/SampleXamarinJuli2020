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
    public partial class SampleImageList : ContentPage
    {
        public SampleImageList()
        {
            InitializeComponent();
            List<ListItem> lstItems = new List<ListItem>();
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Android",
                Description = "Belajar Xamarin for Android",
                Source = "monkey.png"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin IOS",
                Description = "Belajar Xamarin for IOS",
                Source = "monkey2.png"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Forms",
                Description = "Belajar Xamarin Forms",
                Source = "monkey3.png"
            });
            lvData.ItemsSource = lstItems;
        }
    }
}