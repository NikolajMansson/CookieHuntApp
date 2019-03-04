using CookieHuntApp.Models;
using CookieHuntApp.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CookieHuntApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(Settings.Accesstoken))
            {
                MainPage = new NavigationPage(new HomePage());
            }
            else if (string.IsNullOrEmpty(Settings.UserName) && string.IsNullOrEmpty(Settings.Password))
            {

                MainPage = new NavigationPage(new SignInPage());
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
