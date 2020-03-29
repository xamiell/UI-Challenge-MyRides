using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRidesChallenge
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new Views.MainPage());
            nav.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Red);
            nav.SetValue(NavigationPage.BarTextColorProperty, Color.White);

            MainPage = nav;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
