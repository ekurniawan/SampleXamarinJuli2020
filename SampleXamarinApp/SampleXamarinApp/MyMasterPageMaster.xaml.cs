using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleXamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterPageMaster : ContentPage
    {
        public ListView ListView;

        public MyMasterPageMaster()
        {
            InitializeComponent();

            BindingContext = new MyMasterPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MyMasterPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyMasterPageMasterMenuItem> MenuItems { get; set; }

            public MyMasterPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MyMasterPageMasterMenuItem>(new[]
                {
                    new MyMasterPageMasterMenuItem { Id = 0, Title = "Home Page",
                        TargetType=typeof(SampleNavigation),ImageSource="telpon.png" },
                    new MyMasterPageMasterMenuItem { Id = 1, Title = "List Image",
                        TargetType=typeof(SampleImageList),ImageSource="telpon.png"},
                    new MyMasterPageMasterMenuItem { Id = 2, Title = "Custom List",
                        TargetType=typeof(SampleCustomList),ImageSource="telpon.png"},
                    new MyMasterPageMasterMenuItem { Id = 3, Title = "Sample Grid",
                        TargetType=typeof(SampleGridLayout),ImageSource="telpon.png"},
                    new MyMasterPageMasterMenuItem { Id = 4, Title = "Sample Image",
                        TargetType=typeof(SampleImagePage),ImageSource="telpon.png"},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}