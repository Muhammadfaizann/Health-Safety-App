 using System;
using System.Threading.Tasks;
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
            _ = InitializeApp();
        }

        private async Task InitializeApp()
        {
            MainPage = new SplashScreen();
            await Task.Delay(112*40);
            var user = Preferences.Get("UserName", "");
            if (string.IsNullOrEmpty(user))
            {
                MainPage = new LoginPage();
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
