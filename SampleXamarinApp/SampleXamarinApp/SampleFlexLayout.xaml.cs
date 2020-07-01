using SampleXamarinApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleXamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleFlexLayout : ContentPage
    {
        public SampleFlexLayout()
        {
            InitializeComponent();
        }

        async void LoadImage()
        {
            using(WebClient client = new WebClient())
            {
                try
                {
                    Uri uri = new Uri("https://raw.githubusercontent.com/xamarin/docs-archive/master/Images/stock/small/stock.json");
                    byte[] data = await client.DownloadDataTaskAsync(uri);

                    using (Stream stream = new MemoryStream(data))
                    {
                        // Deserialize the JSON into an ImageList object
                        var jsonSerializer = new
                        DataContractJsonSerializer(typeof(ImageList));
                        ImageList imageList =
                        (ImageList)jsonSerializer.ReadObject(stream);
                        // Create an Image object for each bitmap
                        foreach (string filepath in imageList.Photos)
                        {
                            Image image = new Image
                            {
                                Source = ImageSource.FromUri(new Uri(filepath))
                            };
                            flexLayout.Children.Add(image);
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}