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
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        private void btnRightSide(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new RightSide()));
        }

        private void btnSlideUp(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new SlideUp()));
        }

        private void btnSlideDown(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new SlideDown()));
        }

        private void btnQuickInner(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new QuickInner()));
        }
    }
}