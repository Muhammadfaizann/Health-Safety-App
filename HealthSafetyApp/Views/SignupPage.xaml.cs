﻿using HealthSafetyApp.ViewModels;
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
		public SignupPage()
		{
			InitializeComponent();
			this.BindingContext = new SignUpViewModel(Navigation);
		}
		private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}