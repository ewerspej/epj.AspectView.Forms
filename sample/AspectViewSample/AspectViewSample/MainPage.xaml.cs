using Xamarin.Essentials;
using Xamarin.Forms;

namespace AspectViewSample
{
    public partial class MainPage : ContentPage
    {
        public string VideoSource => GetVideo();

        public MainPage()
        {
            InitializeComponent();
        }

        private static string GetVideo()
        {
            return "https://github.com/ewerspej/epj.AspectView.Forms/blob/main/assets/frog113403.mp4?raw=true";
        }
    }
}
