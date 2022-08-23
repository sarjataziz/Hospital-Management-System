using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Users
{
    internal class Bill_Payment
    {
        public int Payment_ID { get; set; }
        public float Total_Bill { get; set; }
        public string Payment_Method{ get; set; }
        //public int Payment_Status { get; set; }
        public DateTime Payment_Date { get; set; }
        public int Patient_ID { get; set; }
    }
}
