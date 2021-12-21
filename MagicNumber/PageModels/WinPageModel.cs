using MagicNumber.Models;

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

        private int _numberOfTries;
        public int NumberOfTries
        {
            get { return _numberOfTries; }
            set => SetProperty(ref _numberOfTries, value);
        }

        public WinPageModel(WinModel win)
        {
            MagicNumber = win.NumberMagic;
            NumberOfTries = win.NumberOfTries;
        }
    }
}
