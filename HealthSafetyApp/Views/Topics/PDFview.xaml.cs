using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HealthSafetyApp.Views.Topics
{
    public partial class PDFview : ContentPage
    {
        string grid_id = "";
        Stream fileStream;
        public PDFview(string id)
        {
            grid_id = id;
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (grid_id == "ABRASIVE WHEELS")
                fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("HealthSafetyApp.PDFfiles.AbrasiveWheels.pdf");
            if (grid_id == "ELECTRICAL TOOLS")
                fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("HealthSafetyApp.PDFfiles.ELECTRICALTOOLS.pdf");
            if (grid_id == "ELECTRICITY")
                fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("HealthSafetyApp.PDFfiles.ElectricityToolbox.pdf");
            if (grid_id == "FIRE")
                fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("HealthSafetyApp.PDFfiles.FireToolbox.pdf");
            if (grid_id == "LADDER")
                fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("HealthSafetyApp.PDFfiles.Ladders.pdf");
            if (grid_id == "HOUSEKEEPING-SLIPS,TRIPS and FALLS")
                fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("HealthSafetyApp.PDFfiles.HOUSEKEEPINGSLIPSTRIPSFALLS.pdf");
            if (grid_id == "HAZARDOUS SUBSTANCES")
                fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("HealthSafetyApp.PDFfiles.HAZARDOUSSUBSTANCES.pdf");
            if (grid_id == "HAND TOOL SAFETY")
            fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("HealthSafetyApp.PDFfiles.HANDTOOLSAFETY.pdf");
            pdfViewerControl.LoadDocument(fileStream);
            pdfViewerControl.IsToolbarVisible = false;
            
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
