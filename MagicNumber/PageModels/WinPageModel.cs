namespace MagicNumber.PageModels
{
    public class WinPageModel : PageModelBase
    {
        private int _magicNumber;
        public int MagicNumber
        {
            get { return _magicNumber; }
            set => SetProperty(ref _magicNumber, value);
        }

        public WinPageModel(int magicNumber)
        {
            MagicNumber = magicNumber;
        }
    }
}
