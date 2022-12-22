using CommunityToolkit.Diagnostics;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace epj.AspectView.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AspectView
    {
        public double AspectRatio
        {
            get => (double)GetValue(AspectRatioProperty);
            set
            {
                Guard.IsGreaterThan(value, 0.0);
                SetValue(AspectRatioProperty, value);
            }
        }

        public static readonly BindableProperty AspectRatioProperty = BindableProperty.Create(nameof(AspectRatio), typeof(double), typeof(AspectView), 1.0);

        public AspectView()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width < 1.0 || height < 1.0)
            {
                return;
            }

            if (HorizontalOptions.Alignment == LayoutAlignment.Fill)
            {
                var newHeight = Width * AspectRatio;
                if (!HeightRequest.Equals(newHeight))
                {
                    HeightRequest = newHeight;
                    MinimumHeightRequest = newHeight;
                    LogUpdate();
                }
                return;
            }

            if (VerticalOptions.Alignment == LayoutAlignment.Fill)
            {
                Guard.IsGreaterThan(AspectRatio, 0.0);
                var newWidth = HeightRequest / AspectRatio;

                if (!WidthRequest.Equals(newWidth))
                {
                    WidthRequest = newWidth;
                    MinimumWidthRequest = newWidth;
                    LogUpdate();
                }
            }
        }

        private void LogUpdate()
        {
            Debug.WriteLine($"{nameof(AspectView)} updated: {nameof(AspectRatio)}: {AspectRatio}, {nameof(WidthRequest)}: {WidthRequest}, {nameof(HeightRequest)}: {HeightRequest}");
        }
    }
}