using System.IO;
using System.Threading.Tasks;
namespace  HealthSafetyApp.Helpers
{ 
    public interface ISave
    {
        //Method to save document as a file and view the saved document
        string Save(MemoryStream fileStream);
    }
}
