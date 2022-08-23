using Hospital_Management_System.User_Data_Access;
using Hospital_Management_System.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Application = System.Windows.Application;

namespace Hospital_Management_System.View_Layer
{
    public partial class Doctor_Menu_Form : Form
    {
        public int userId = 0;

        public Doctor_Menu_Form()
        {
            InitializeComponent();
        }

        public Doctor_Menu_Form(int User_ID)
        {
            InitializeComponent();

            this.userId = User_ID;

            DoctorDataAccess doctorDataAccess = new DoctorDataAccess();
            Doctor doctor = doctorDataAccess.GetDoctorByUserID(User_ID);
            Doctor_ID_TextBox.Text = doctor.Doctor_ID.ToString();
            Doctor_Name_TextBox.Text = doctor.Name;
            EmailTextBox.Text = doctor.Email;
            MobileTextBox.Text = doctor.Mobile;
            BloodGroupTextBox.Text = doctor.Blood_Group;
        }

        private void Doctor_Menu_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) // Doctor LogOut
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();
            login_Form.Show();
        }

        private void DoctorProfile_Buton_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Menu_Form_Load(object sender, EventArgs e)
        {
        }

        private void Doctor_Patients_Button_Click(object sender, EventArgs e)
        {
            PatientsManage patientsManage = new PatientsManage();

            this.Hide();
            patientsManage.Show();
        }

        private void Doctor_Prescription_Button_Click(object sender, EventArgs e)
        {
            Write_Prescription write_Prescription = new Write_Prescription();

            this.Hide();
            write_Prescription.Show();
        }

        private void Doctor_Test_Button_Click(object sender, EventArgs e)
        {
            TestManage testManage = new TestManage();

            this.Hide();
            testManage.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Doctor_Manage_Room doctor_Manage_Room = new Doctor_Manage_Room();

            this.Hide();
            doctor_Manage_Room.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doctor_Department doctor_Department = new Doctor_Department();

            this.Hide();
            doctor_Department.Show();
        }
    }
}
