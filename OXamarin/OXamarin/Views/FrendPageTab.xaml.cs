using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrendPageTab : ContentPage
    {
        public ImageSource Image { get; set; }
        public FrendPageTab()
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource("OXamarin.Images.OguriShun.png");
            // = new List<ImageSource>
            //{
            //    ImageSource.FromResource("OXamarin.Images.OguriShun.png"),
            //    ImageSource.FromResource("OXamarin.Images.OguriShun.png"),
            //    ImageSource.FromResource("OXamarin.Images.OguriShun.png"),
            //};
            //image = new Image
            //{
            //    Source = ImageSource.FromResource("OXamarin.Images.OguriShun.png"),
            //};
            this.lbl.Text ="ラベル";
        }
    }
}
