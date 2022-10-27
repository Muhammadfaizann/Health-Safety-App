using HealthSafetyApp.Helpers;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(LoadToPdfViewer.Droid.DependencyService))]

namespace LoadToPdfViewer.Droid
{
    internal class DependencyService : IDependencyService
    {
        public Task<Stream> LoadDocumentToViewer(string filePath)
        {

           

            FileStream Fstream = new FileStream(filePath, FileMode.Open);
            Stream fileStream = Fstream as Stream;

            return Task.FromResult(fileStream);
        }
    }
}
