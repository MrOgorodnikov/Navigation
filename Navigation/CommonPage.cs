using System;

using Xamarin.Forms;

namespace Navigation
{
    public class CommonPage : ContentPage
    {
        public CommonPage()
        {
            Title = "Common";

            var backBtn = new Button
            {
                Text = "  Back  ",
                BorderWidth = 1,
                Margin = new Thickness(10)
            };

            backBtn.Clicked += BackBtn_Clicked;

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" },
                    backBtn
                }
            };
        }

        async void BackBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

