using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSafetyApp.Helpers
{
    public interface IDependencyService
    {
        Task<Stream> LoadDocumentToViewer(string filePath);
    }
}
