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
	public partial class RightSide : MenuContainerPage
	{
		public RightSide ()
		{
			InitializeComponent ();
            this.SlideMenu = new RightSideMasterDetail();
		}

        private void btnShowMenu(object sender, EventArgs e)
        {
            ShowMenu();
        }

        private void btnHideMenu(object sender, EventArgs e)
        {
            HideMenu();
        }
    }
}