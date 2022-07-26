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
    public partial class SignupPageSecond : ContentPage
    {
        public SignupPageSecond(SignUpViewModel viewModel)
        {
            InitializeComponent();
            this.BindingContext = viewModel;
        }
    }
}