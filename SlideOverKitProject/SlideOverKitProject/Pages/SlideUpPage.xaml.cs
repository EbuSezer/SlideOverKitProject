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
	public partial class SlideUpPage : SlideMenuView
	{
		public SlideUpPage ()
		{
			InitializeComponent ();
            this.HeightRequest = 250;
            this.IsFullScreen = true;
            this.MenuOrientations = MenuOrientation.BottomToTop;
            this.BackgroundColor = Color.Yellow;
        }
	}
}