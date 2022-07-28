using System;
using System.Collections.Generic;
using System.Text;

namespace HealthSafetyApp
{
   public interface IAndroidExternalStorageWriter
    {
        string CreateFile(string filename, byte[] bytes);
    }
}
