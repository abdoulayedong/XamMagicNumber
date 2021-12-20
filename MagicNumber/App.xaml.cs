using MagicNumber.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicNumber
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new WelcomePage());
            MainPage = nav;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
