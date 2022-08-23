using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Users
{
    internal class Room
    {
        public int Room_ID { get; set; }
        public int Room_No { get; set; }
        public string Room_Type { get; set; }
        public float Room_Cost { get; set; }
        public int Patient_ID { get; set; }
    }
}
