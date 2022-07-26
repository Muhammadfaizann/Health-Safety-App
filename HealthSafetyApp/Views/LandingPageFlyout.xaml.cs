using HealthSafetyApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthSafetyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPageFlyout : ContentPage
    {
        //public ListView ListView;

        public LandingPageFlyout()
        {
            InitializeComponent();
            this.BindingContext = new LandingPageViewModel(Navigation);

         
        }
        public void facebook_clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.facebook.com"));
        }
        public void youtube_clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.youtube.com"));
        }
        public void twitter_clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.twitter.com"));
        }
        public void phone_clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel: +962799892728"));
        }
        public void linkedin_clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.linkedin.com"));
        }
        public void contactus_clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("mailto:support@thehealthandsafetyapp.co.uk"));
        }

    }
}