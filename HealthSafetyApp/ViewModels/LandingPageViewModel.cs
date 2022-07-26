using HealthSafetyApp.Models;
using HealthSafetyApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HealthSafetyApp.ViewModels
{
   public class LandingPageViewModel  :BaseViewModel
    {
        public INavigation Navigation { get; set; }
       
        public ICommand EmailCommand { get; set; }
        public ICommand LogOutCommand { get; set; }
        public ICommand NavigationCommand { get; set; }
        public LandingPageViewModel(INavigation navigation)
        {
            this.Navigation = navigation;

            EmailCommand = new Command( () => {  SendEmail(); });
            NavigationCommand = new Command((item) => { PageNavigation(item); });
            LogOutCommand = new Command(() =>
              {
                  if (IsBusy)
                      return;
                  try
                  {
                      IsBusy = true;
                      Preferences.Remove("UserName");
                      Application.Current.MainPage = new LoginPage();
                  }
                  catch (Exception ex)
                  {

                  }
                  IsBusy = false;

              });
            
        }

        private async void PageNavigation(object item)
        {
            
            
        }
        bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        private async void SendEmail()
        {
           // var emailReceiver = Preferences.Get("UserName", "");

            //await Email.ComposeAsync("","", "support@thehealthandsafetyapp.co.uk");
            Device.OpenUri(new Uri("mailto:support@thehealthandsafetyapp.co.uk"));

        }
    }
}
