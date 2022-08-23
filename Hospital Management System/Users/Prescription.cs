using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Users
{
    internal class Prescription
    {
        public int Prescription_ID { get; set; }
        public int Doctor_ID { get; set; }
        public int Patient_ID { get; set; }
        public string Prescription_Details { get; set; }
        public string Sickness { get; set; }
        public string Blood_Group { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
    }
}
