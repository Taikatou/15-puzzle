using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Xuzzle
{
    public class menu : ContentPage
    {
        Button fifteenButton;
        Button eightButton;
        public menu()
        {
            eightButton = new Button
            {
                Text = "8 puzzle",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            eightButton.Clicked += eightClick;

            fifteenButton = new Button
            {
                Text = "15 puzzle",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            fifteenButton.Clicked += fifteenClick;

            Content = new StackLayout
            {
                Children = {
                    eightButton,
                    fifteenButton,
                }
            };
        }

        async void eightClick(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new XuzzlePage(3));
        }

        async void fifteenClick(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new XuzzlePage(4));
        }
    }
}
