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
    public partial class SampleListString : ContentPage
    {
        public SampleListString()
        {
            InitializeComponent();

            /*List<string> lstNama = new List<string>
            {
                "Erick","Budi","Bambang","Claude","Bruno"
            };*/
            List<string> lstNama = new List<string>();
            lstNama.Add("Erick");
            lstNama.Add("Budi");
            lstNama.Add("Bambang");
            lstNama.Add("Claude");
            lstNama.Add("Bruno");

            lvName.ItemsSource = lstNama;
        }

        private void lvName_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var itemSelect = (string)e.Item;
            DisplayAlert("Keterangan", $"Anda memilih item: {itemSelect}", "OK");
        }
    }
}