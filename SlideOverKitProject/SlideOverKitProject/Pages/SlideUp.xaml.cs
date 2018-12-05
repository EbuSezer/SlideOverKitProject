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
    public partial class SlideUp : MenuContainerPage
    {
        public SlideUp()
        {
            InitializeComponent();
            this.SlideMenu = new SlideUpPage();
        }
        private void btnshowMenu(object sender,EventArgs e)
        {
            ShowMenu();
        }

        private void btnhideMenu(object sender, EventArgs e)
        {
            HideMenu();
        }
    }
}