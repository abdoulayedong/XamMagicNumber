using MagicNumber.Models;
using MagicNumber.PageModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicNumber.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WinPage : ContentPage
    {
        public WinPage(WinModel magicNumber)
        {
            InitializeComponent();
            BindingContext = new WinPageModel(magicNumber);
        }

        private void AnimationView_OnFinishedAnimation(object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}