using MagicNumber.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MagicNumber.PageModels
{
    public class WelcomePageModel 
    {
        public WelcomePageModel()
        {
            NavigateToGame = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new GamePage(), true);
            });
        }

        public ICommand NavigateToGame { get; }
    }
}
