using MagicNumber.Pages;
using MagicNumber.Services;
using Xamarin.Forms;

namespace MagicNumber
{
    public partial class App : Application
    {
        public App()
        {
            DependencyService.Register<IMessageService, MessageService>();
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
