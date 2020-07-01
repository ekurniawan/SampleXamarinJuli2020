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
    public partial class SampleGridLayout : ContentPage
    {
        public SampleGridLayout()
        {
            InitializeComponent();
        }

        private void btnHitung_Clicked(object sender, EventArgs e)
        {
            double hasil = 0;
            double bil1 = Convert.ToDouble(txtBil1.Text);
            double bil2 = Convert.ToDouble(txtBil2.Text);

            var btn = (Button)sender;

            switch (btn.Text)
            {
                case "+":
                    hasil = bil1 + bil2;
                    break;
                case "-":
                    hasil = bil1 - bil2;
                    break;
                case "*":
                    hasil = bil1 * bil2;
                    break;
                case "/":
                    hasil = bil1 / bil2;
                    break;
            }
            txtHasil.Text = $"{hasil}";
        }
    }
}