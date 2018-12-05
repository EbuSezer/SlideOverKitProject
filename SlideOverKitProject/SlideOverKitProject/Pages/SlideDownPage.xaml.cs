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
	public partial class SlideDownPage : SlideMenuView
	{
		public SlideDownPage ()
		{
			InitializeComponent ();
            this.HeightRequest = 600;
            this.IsFullScreen = true;
            this.MenuOrientations = MenuOrientation.TopToBottom;
            this.BackgroundColor = Color.FromHex("#D8DDE7");
        }
	}
}