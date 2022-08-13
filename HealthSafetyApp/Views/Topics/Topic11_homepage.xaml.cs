using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HealthSafetyApp.Views.Topics
{
    public partial class Topic11_homepage : ContentPage
    {


        public Topic11_homepage()
        {
            InitializeComponent();
            this.Title = "TOOLBOX TALKS";
            string dt = DateTime.Now.ToString();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

        }

        private async void OpenPdfFiles(object sender, EventArgs e)
        {
            try
            {
                var button = (Button)sender;
                await Navigation.PushModalAsync(new PDFview(button.Text.ToString()));
                /*var fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("HealthSafetyApp.PDFfiles.AbrasiveWheels.pdf");

                using (var memorySteam = new MemoryStream())
                {
                    await fileStream.CopyToAsync(memorySteam);
                    await CrossXamarinFormsSaveOpenPDFPackage.Current.SaveAndView("Myfile.pdf", "application/pdf", memorySteam, PDFOpenContext.InApp);
                }*/
            }
            catch (Exception ex)
            {

            }
        }


    }

}
