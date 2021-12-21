using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MagicNumber.Controls
{
    public class BottomBoxView : BoxView
    {
        public BottomBoxView()
        {
            HorizontalOptions = LayoutOptions.FillAndExpand;
            HeightRequest = 150;
            Scale = 1.2;
            ScaleY = 1.2;
            Rotation = -10;
            BackgroundColor = (Color)Application.Current.Resources["SecondaryColor"];
        }
    }
}
