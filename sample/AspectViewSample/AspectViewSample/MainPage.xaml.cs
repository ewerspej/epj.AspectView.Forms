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
            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                return "https://github.com/dotnet/maui-samples/blob/main/6.0/UserInterface/Handlers/CreateHandlerDemo/VideoDemos/Resources/Raw/AndroidVideo.mp4?raw=true";
            }

            if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                return "https://github.com/dotnet/maui-samples/blob/main/6.0/UserInterface/Handlers/CreateHandlerDemo/VideoDemos/Resources/Raw/AppleVideo.mp4?raw=true";
            }

            return string.Empty;
        }
    }
}
