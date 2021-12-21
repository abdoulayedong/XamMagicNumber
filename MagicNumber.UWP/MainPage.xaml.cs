namespace MagicNumber.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new MagicNumber.App());
        }
    }
}
