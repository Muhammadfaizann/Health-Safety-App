using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using UIKit;
using QuickLook;
using HealthSafetyApp.Helpers;

[assembly: Dependency(typeof(SaveIOS))]

    class SaveIOS: ISave
    {
    public string Save(MemoryStream fileStream)
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        string filepath = Path.Combine(path, "SavedDocument.pdf");

        FileStream outputFileStream = File.Open(filepath, FileMode.Create);
        fileStream.Position = 0;
        fileStream.CopyTo(outputFileStream);
        outputFileStream.Close();
        return filepath;
    }
}
