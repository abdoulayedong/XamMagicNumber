using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicNumber.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimationView : ContentView
    {
        public AnimationView()
        {
            InitializeComponent();
            Animation();
        }

        private async void Animation()
        {
            await Task.WhenAny<bool>(
                star1.RotateTo(180, 1000, easing: Easing.Linear),
                star2.RotateTo(180, 1000, easing: Easing.Linear),
                star3.RotateTo(180, 1000, easing: Easing.Linear)
                );
        }
    }
}