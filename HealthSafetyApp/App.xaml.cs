 using System;
using System.Threading.Tasks;
using HealthSafetyApp.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzE0NTk3QDMyMzAyZTMyMmUzMGE2N1VVZkNoVVRpZFFyLzFJU0pONlZxZTgvL2ZhZEl6Z3RkMHJlbHcvMXc9");
            AppCenter.Start("android=1503dec4-6dea-4e7d-aae1-144316aea7cb;" +
                  "ios=3f757ca2-3635-4866-9cc5-ec8f739fb74f;" +
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
