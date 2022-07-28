using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HealthSafetyApp.Droid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
[assembly: Xamarin.Forms.Dependency(typeof(AndroidExternalStorageWriter))]
namespace HealthSafetyApp.Droid
{
    public class AndroidExternalStorageWriter : IAndroidExternalStorageWriter
    {
        public string CreateFile(string filename, byte[] bytes)
        {
            if (!Directory.Exists(Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, "KashPDF")))
                Directory.CreateDirectory(Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, "KashPDF"));

            var path = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, "KashPDF", filename);

            File.WriteAllBytes(path, bytes);

            return path;
        }
    }
}