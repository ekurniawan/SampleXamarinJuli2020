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
    public partial class SampleParam2 : ContentPage
    {
        public SampleParam2()
        {
            InitializeComponent();
            
        }

        private string _param1,_param2;
        public SampleParam2(string param1,string param2)
        {
            InitializeComponent();
            _param1 = param1;
            _param2 = param2;

            lblParam.Text = $"{_param1} dan {_param2}";
        }
    }
}