using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HealthSafetyApp.Views
{
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            InitializeComponent();
            _ = RunAnimationAsync();
        }

        private async Task RunAnimationAsync()
        {
            for (int i = 1; i<= 39; i++)
            {
                placeholder.Source = "frame_"+i+".png";
                await Task.Delay(112);
            }
        }
    }
}
