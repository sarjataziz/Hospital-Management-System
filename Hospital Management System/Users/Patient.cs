using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Users
{
    internal class Patient
    {
        public int Patient_ID { get; set; }
        public string Name { get; set; }
        public int User_ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string Blood_Group { get; set; }
        public string Gender { get; set; }
        public DateTime Accepted_Date { get; set; }
        public string Prescription_Details { get; set; }
        public string Sickness { get; set; }
        public string Prescription_ID { get; set; }
    }
}
