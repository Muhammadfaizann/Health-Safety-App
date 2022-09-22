using System;
using System.IO;
using Android.Content;
using Java.IO;
using Xamarin.Forms;
using System.Threading.Tasks;
using Android.Support.V4.Content;
using Android;
using Android.Content.PM;
using Android.Support.V4.App;
using HealthSafetyApp.Helpers;

[assembly: Dependency(typeof(SaveAndroid))]

class SaveAndroid : ISave
{
    public string Save(MemoryStream stream)
    {
        string root = null;
        string fileName = "SavedDocument.pdf";
        if (Android.OS.Environment.IsExternalStorageEmulated)
        {
            root = Android.OS.Environment.ExternalStorageDirectory.ToString();
        }
        Java.IO.File myDir = new Java.IO.File(root + "/Syncfusion");
        myDir.Mkdir();
        Java.IO.File file = new Java.IO.File(myDir, fileName);
        string filePath = file.Path;
        if (file.Exists()) file.Delete();
        Java.IO.FileOutputStream outs = new Java.IO.FileOutputStream(file);
        outs.Write(stream.ToArray());
        var ab = file.Path;
        outs.Flush();
        outs.Close();
        return filePath;
    }
}
