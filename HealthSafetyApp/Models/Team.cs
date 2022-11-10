using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        [JsonConstructor]
        public Team(int SNo, int Name, int Win, int Loose, double Percentage, string Conf, string Div, int Home, string Road, string Last10, int Streak, string Logo)
        {
            this.SNo = SNo;
            this.Name = Name;
            this.Win = Win;
            this.Loose = Loose;
            this.Percentage = Percentage;
            this.Conf = Conf;
            this.Div = Div;
            this.Home = Home;
            this.Road = Road;
            this.Last10 = Last10;
            this.Streak = Streak;
            this.Logo = Logo;
        }

        public Team()
        {

        }


    }
}
