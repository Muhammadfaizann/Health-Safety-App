using HealthSafetyApp.ViewModels;
using System;
using System.Collections.Generic;
using Acr.UserDialogs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HealthSafetyApp.Views.Topics;

namespace HealthSafetyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPageDetail : ContentPage
    {
        LandingPage landingPage;
        public LandingPageDetail()
        {
            InitializeComponent();
            this.BindingContext = new LandingPageViewModel(Navigation);
            var topic = new List<Nav>() {
            new Nav() {Id = 0, Name = "Dynamic Risk Assessment"},
            new Nav() {Id = 1, Name = "ESS COSHH Assessment"},
            new Nav() {Id = 2, Name = "Work Station Self Assessment"},
            new Nav() {Id = 3, Name = "Manual Handling Risk Assessment"},
            new Nav() {Id = 4, Name = "ACCIDENT RECORD FORM"},
            new Nav() {Id = 5, Name = "Safe Systems of Work Tool"},
            new Nav() {Id = 10, Name = "TOOLBOX TALKS"},
            };
        }
        
        public async void OnTap_Nav_List(object sender, EventArgs args)
        {
            string filename = "1";
            //// var abc = Nav_List.SelectedItem;
            UserDialogs.Instance.ShowLoading();
            Button ListSelectedItem = (Button)sender;
            var gid = ListSelectedItem.ClassId;
            if (gid == "0")
                await Navigation.PushAsync(new Topic1(filename));
            if (gid == "1")
                await Navigation.PushAsync(new Topic2(filename));
            if (gid == "2")
                await Navigation.PushAsync(new Topic3(filename));
            if (gid == "3")
                await Navigation.PushAsync(new Topic4(filename));
            if (gid == "4")
                await Navigation.PushAsync(new Topic5(filename));
            if (gid == "5")
                await Navigation.PushAsync(new Topic6(filename));
            if (gid == "6")
                await Navigation.PushAsync(new Topic11_homepage());
            if (gid == "7")
                await Navigation.PushAsync(new AuditForm(filename));


            UserDialogs.Instance.HideLoading();
        }
        private void OnTap_openpdffolderAsync(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private  void OnTap_opendraftrsfolderAsync(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        void MenuBarTapped(System.Object sender, System.EventArgs e)
        {
            var flyout = (FlyoutPage)Application.Current.MainPage;
            flyout.IsPresented = true;
        }
    }
    class Nav
    {
        public string Name
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

    }
}