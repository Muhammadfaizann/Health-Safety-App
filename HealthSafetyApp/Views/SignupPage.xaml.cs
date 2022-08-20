using HealthSafetyApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthSafetyApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignupPage : ContentPage
	{
		string TermsAndCondtions = "Email address is mandatory for confirmation of your registration for this resource. HAS APP may from time to time send updates about HAS APP and other relevant products and services.By providing your contact information you consent to being contacted for direct marketing purposes by HAS APP.";
		DatePicker datePicker;
		public SignupPage()
		{
			InitializeComponent();
			this.BindingContext = new SignUpViewModel(Navigation);
			datePicker = (DatePicker)FindByName("dateOfBirth");
		}
		private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		private void RoundedEntry_Focused(System.Object sender, Xamarin.Forms.FocusEventArgs e)
        {
			datePicker.Focus();
		}

        async void OpenTermsConditionsPopup(System.Object sender, System.EventArgs e)
        {
			await App.Current.MainPage.DisplayAlert("Terms and Conditions", TermsAndCondtions, "Ok");
			checkbox.IsEnabled = true;
		}

        void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
        }
    }
}