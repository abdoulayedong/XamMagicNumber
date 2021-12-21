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

        private async Task Animation()
        {
            await Task.WhenAny(RotateStar(star1, 7), RotateStar(star2, 13), RotateStar(star3, 25));
        }

        private async Task RotateStar(VisualElement element, int speed)
        {
            int endRotation = speed - 1;
            while (true)
            {
                for (int i = 1; i < speed; i++)
                {
                    if (element.Rotation >= 360f)
                        element.Rotation = 0;
                    await element.RotateTo(i * (360 / endRotation), easing: Easing.Linear);
                }
            }
        }       
    }
}