using System;
using HealthSafetyApp.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthSafetyApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var user = Preferences.Get("UserName", "");
            if (string.IsNullOrEmpty(user))
            {
                MainPage = new LandingPage();
            }
            else
            {
                MainPage = new LandingPage();
            }
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
