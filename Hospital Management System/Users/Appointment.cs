using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Users
{
    internal class Appointment
    {
        public int Appointment_ID { get; set; }
        public int Patient_ID { get; set; }
        public int Doctor_ID { get; set; }
        public DateTime Accepted_Date { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        //public string Department_Name { get; set; }
    }
}
