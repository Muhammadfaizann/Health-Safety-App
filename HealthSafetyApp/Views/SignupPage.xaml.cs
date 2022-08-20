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
		List<string> countries = new List<string> {"Afghanistan","Albania","Algeria","Andorra","Angola","Antigua and Barbuda","Argentina","Armenia","Australia","Austria"
,"Azerbaijan","Bahamas","Bahrain","Bangladesh","Barbados","Belarus","Belgium","Belize","Benin","Bhutan","Bolivia","Bosnia and Herzegovina","Botswana","Brazil"
,"Brunei","Bulgaria","Burkina Faso","Burundi","Cabo Verde","Cambodia","Cameroon","Canada","Central African Republic (CAR)","Chad","Chile","China","Colombia"
,"Comoros","Congo","Costa Rica","Cote d'Ivoire","Croatia","Cuba","Cyprus","Czechia","Denmark","Djibouti","Dominica","Dominican Republic","Ecuador","Egypt"
,"El Salvador","Equatorial Guinea","Eritrea","Estonia","Eswatini","Ethiopia","Fiji","Finland","France","Gabon","Gambia","Georgia","Germany","Ghana","Greece"
,"Grenada","Guatemala","Guinea","Guinea-Bissau","Guyana","Haiti","Honduras","Hungary","Iceland","India","Indonesia","Iran","Iraq","Ireland","Israel","Italy"
,"Jamaica","Japan","Jordan","Kazakhstan","Kenya","Kiribati","Kosovo","Kuwait","Kyrgyzstan","Laos","Latvia","Lebanon","Lesotho","Liberia","Libya","Liechtenstein"
,"Lithuania","Luxembourg","Madagascar","Malawi","Malaysia","Maldives","Mali","Malta","Marshall Islands","Mauritania","Mauritius","Mexico","Micronesia","Moldova"
,"Monaco","Mongolia","Montenegro","Morocco","Mozambique","Myanmar","Namibia","Nauru","Nepal","Netherlands","New Zealand","Nicaragua","Niger"
,"Nigeria","North Korea","North Macedonia","Norway","Oman","Pakistan","Palau","Palestine","Panama","Papua New Guinea","Paraguay","Peru","Philippines"
,"Poland","Portugal","Qatar","Romania","Russia","Rwanda","Saint Kitts and Nevis","Saint Lucia","Saint Vincent and the Grenadines","Samoa","San Marino"
,"Sao Tome and Principe","Saudi Arabia","Senegal","Serbia","Seychelles","Sierra Leone","Singapore","Slovakia","Slovenia","Solomon Islands","Somalia"
,"South Africa","South Korea","South Sudan","Spain","Sri Lanka","Sudan","Suriname","Sweden","Switzerland","Syria","Taiwan","Tajikistan","Tanzania"
,"Thailand","Timor-Leste","Togo","Tonga","Trinidad and Tobago","Tunisia","Turkey","Turkmenistan","Tuvalu","Uganda","Ukraine","United Arab Emirates (UAE)"
,"United Kingdom (UK)","United States of America (USA)","Uruguay","Uzbekistan","Vanuatu","Vatican City (Holy See)","Venezuela","Vietnam","Yemen"
,"Zambia","Zimbabwe" };
		List<string> industries = new List<string> { "Software Development", "Mobile Development", "Web development" };
		public SignupPage()
		{
			InitializeComponent();
			this.BindingContext = new SignUpViewModel(Navigation);

			countryPicker.ItemsSource = countries;
            countryPicker.SelectedIndexChanged += CountryPicker_SelectedIndexChanged;

			industryPicker.ItemsSource = industries;
            industryPicker.SelectedIndexChanged += IndustryPicker_SelectedIndexChanged;

            dobPicker.DateSelected += DobPicker_DateSelected;

			MessagingCenter.Subscribe<object, string>(this, "DOB", (sender, arg) =>
			{
				Device.BeginInvokeOnMainThread(() => {
					var check = dobPicker.Focus();
				});
			}, BindingContext);
			MessagingCenter.Subscribe<object, string>(this, "Country", (sender, arg) =>
			{
				Device.BeginInvokeOnMainThread(() => {
					var check = countryPicker.Focus();
				});
			}, BindingContext);
			MessagingCenter.Subscribe<object, string>(this, "Industry Type", (sender, arg) =>
			{
				Device.BeginInvokeOnMainThread(() => {
					var check = industryPicker.Focus();
				});
			}, BindingContext);
		}

        private void IndustryPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
			industy.Text = industryPicker.SelectedItem.ToString();
		}
        private void DobPicker_DateSelected(object sender, DateChangedEventArgs e)
        {
			dob.Text = e.NewDate.ToShortDateString();
		}
        private void CountryPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
			country.Text = countryPicker.SelectedItem.ToString();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}

        async void OpenTermsConditionsPopup(System.Object sender, System.EventArgs e)
        {
			await App.Current.MainPage.DisplayAlert("Terms and Conditions", TermsAndCondtions, "Ok");
			checkbox.IsEnabled = true;
		}
    }
}