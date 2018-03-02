using System;

using Xamarin.Forms;

namespace Navigation
{
    public class StartPage : TabbedPage
    {
        public StartPage()
        {
            Children.Add(new ModalPage());
            Children.Add(new CommonPage());
             
            //var modalPage = new Button
            //{
            //    Text = "  Open modal page  ",
            //    Margin = new Thickness(10)
            //};
            //modalPage.Clicked += ModalPage_Clicked;

            //var contentPage = new Button
            //{
            //    Text = "  Open content page  ",
            //    Margin = new Thickness(10)
            //};
            //contentPage.Clicked += ContentPage_Clicked;

            //var e = new Entry();

            //Content = new StackLayout
            //{
            //    Children = {
            //        modalPage,
            //        contentPage,
            //        e
            //    }
            //};
        }

        void ModalPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ModalPage());
        }

        void ContentPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CommonPage()); 

        }
    }
}

