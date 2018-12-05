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
    public partial class QuickInner : MenuContainerPage
    {
        public QuickInner()
        {
            InitializeComponent();

        }

        private void btnright(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new QuickInner { SlideMenu = new QuickInnerPage(MenuOrientation.RightToLeft) });
        }

        private void btnleft(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new QuickInner { SlideMenu = new QuickInnerPage(MenuOrientation.LeftToRight) });
        }

        private void btntop(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new QuickInner { SlideMenu = new QuickInnerPage(MenuOrientation.TopToBottom) });
        }

        private void btnbottom(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new QuickInner { SlideMenu = new QuickInnerPage(MenuOrientation.BottomToTop) });
        }
    }
}

