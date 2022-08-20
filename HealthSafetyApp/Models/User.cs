using System;
using System.Collections.Generic;
using System.Text;

namespace HealthSafetyApp.Models
{
   public class User
    {
      
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Organization { get; set; }
        public string Position { get; set; }
        public string Industry { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string DOB { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Telephone { get; set; }
      
    }
}
