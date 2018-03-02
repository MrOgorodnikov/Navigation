using System;

using Xamarin.Forms;

namespace Navigation
{
    public class ModalPage : ContentPage
    {
        public ModalPage()
        {
            Title = "Modal";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

