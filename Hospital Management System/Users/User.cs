using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Users
{
    internal class User
    {
        public int User_ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string User_Type { get; set; }
        public string User_Status { get; set; }
       // public string User_Image { get; set; }
    }
}
