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
    public partial class EditEmployee : ContentPage
    {
        public EditEmployee()
        {
            InitializeComponent();
        }

        private void btnEdit_Clicked(object sender, EventArgs e)
        {

        }
    }
}