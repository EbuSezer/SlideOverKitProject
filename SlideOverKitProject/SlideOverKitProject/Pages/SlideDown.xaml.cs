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
	public partial class SlideDown : MenuContainerPage
	{
		public SlideDown ()
		{
			InitializeComponent ();
            this.SlideMenu = new SlideDownPage();
		}

        private void btnTikla(object sender, EventArgs e)
        {
            ShowMenu();
        }
    }
}