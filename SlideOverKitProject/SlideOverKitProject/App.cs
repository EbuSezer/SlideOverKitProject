using SlideOverKitProject.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SlideOverKitProject
{
   public class App : Xamarin.Forms.Application
    {
        public App()
        {
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
