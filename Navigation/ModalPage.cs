using System;

using Xamarin.Forms;

namespace Navigation
{
    public class ModalPage : ContentPage
    {
        public ModalPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

