using MagicNumber.PageModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicNumber.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WinPage : ContentPage
    {
        public WinPage(int magicNumber)
        {
            InitializeComponent();
            BindingContext = new WinPageModel(magicNumber);
        }
    }
}