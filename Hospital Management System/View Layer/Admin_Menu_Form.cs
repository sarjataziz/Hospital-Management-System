using Hospital_Management_System.User_Data_Access;
using Hospital_Management_System.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System.View_Layer
{
    public partial class Admin_Menu_Form : Form
    {
        public int userId = 0;

        public Admin_Menu_Form()
        {
            InitializeComponent();

            User user = new User();

            user.Username = Admin_Username_TextBox.Text;
        }

        public Admin_Menu_Form(int User_ID)
        {
            InitializeComponent();

            this.userId = User_ID;

            AdminDataAccess access = new AdminDataAccess();
            Admin admin = access.GetAdminByUserID(User_ID);
            Admin_ID_TextBox.Text = admin.Admin_ID.ToString();
            Admin_Username_TextBox.Text = admin.User_ID.ToString();
            EmailTextBox.Text = admin.Email;
            Admin_Name_TextBox.Text = admin.Name;
        }


        private void Admin_Menu_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Doctor_Button_Click(object sender, EventArgs e)
        {
            Manage_Doctors manage_Doctors = new Manage_Doctors();

            this.Hide();
            manage_Doctors.Show();
        }

        private void Admin_Patient_Button_Click(object sender, EventArgs e)
        {
            Manage_Patients manage_Patients = new Manage_Patients();

            this.Hide();
            manage_Patients.Show();
        }

        private void Admin_Logout_Button_Click_1(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();
            login_Form.Show();
        }

        private void button1_Click(object sender, EventArgs e) //Room Button
        {
            Manage_Room manage_Room = new Manage_Room();

            this.Hide();
            manage_Room.Show();
        }

        private void button2_Click(object sender, EventArgs e) //Department Button
        {
            Manage_Department manage_Department = new Manage_Department();

            this.Hide();
            manage_Department.Show();
        }

        private void button3_Click(object sender, EventArgs e) //Bill_Payment Button
        {
            Manage_Bill_Payment manage_Bill_Payment = new Manage_Bill_Payment();

            this.Hide();
            manage_Bill_Payment.Show();
        }

        private void Admin_Test_Button_Click(object sender, EventArgs e)
        {
            Manage_Test manage_Test = new Manage_Test();

            this.Hide();
            manage_Test.Show();
        }

        private void Admin_Menu_Form_Load(object sender, EventArgs e)
        {
            User user = new User();

            user.Username = Admin_Username_TextBox.Text;

            Doctor doctor = new Doctor();

            doctor.Username = Admin_Username_TextBox.Text;
            doctor.Name = Admin_Name_TextBox.Text;
        }
    }
}
