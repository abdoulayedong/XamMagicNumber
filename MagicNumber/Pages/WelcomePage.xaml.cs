
using FormsControls.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicNumber.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage, IAnimationPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        public IPageAnimation PageAnimation { get; } = new FlipPageAnimation { Duration = AnimationDuration.Long, Subtype = AnimationSubtype.FromTop };

        public void OnAnimationFinished(bool isPopAnimation)
        {
        }

        public void OnAnimationStarted(bool isPopAnimation)
        {
        }
    }
}