using SlideOverKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SlideOverKitProject.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuickInnerPage : SlideMenuView
	{
		public QuickInnerPage (MenuOrientation orientation)
		{
			InitializeComponent ();
            this.IsFullScreen = false;
            this.BackgroundViewColor = Color.Transparent;
            this.BackgroundColor = Color.FromHex("#C82630");
            this.MenuOrientations = orientation;
            if (orientation == MenuOrientation.BottomToTop)
            {
                this.WidthRequest = 50;
                this.HeightRequest = 200;

                this.DraggerButtonHeight = 30;
                this.LeftMargin = 100;

            }

            if (orientation == MenuOrientation.TopToBottom)
            {
                this.WidthRequest = 50;
                this.HeightRequest = 200;
                this.DraggerButtonHeight = 40;
                this.LeftMargin = 100;

            }

            if (orientation == MenuOrientation.LeftToRight)
            {
                this.WidthRequest = 200;
                this.HeightRequest = 50;
                this.DraggerButtonWidth = 40;
                this.TopMargin = 30;

            }

            if (orientation == MenuOrientation.RightToLeft)
            {
                this.WidthRequest = 200;
                this.HeightRequest = 50;
                this.DraggerButtonWidth = 30;
                this.TopMargin = 30;
            }
        }
	}
}