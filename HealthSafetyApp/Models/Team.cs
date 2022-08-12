using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSafetyApp.Models
{
    public class Team
    {
        public int SNo { get; set; }
        public int Name { get; set; }
        public int Win { get; set; }
        public int Loose { get; set; }
        public double Percentage { get; set; }
        public string Conf { get; set; }
        public string Div { get; set; }
        public int Home { get; set; }
        public string Road { get; set; }
        public string Last10 { get; set; }
        public int Streak { get; set; }
        public string Logo { get; set; }
    }
}
