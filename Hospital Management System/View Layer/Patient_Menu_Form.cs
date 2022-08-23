using Hospital_Management_System.User_Data_Access;
using Hospital_Management_System.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System.View_Layer
{
    public partial class Patient_Menu_Form : Form
    {
        public int userId = 0;

        public Patient_Menu_Form()
        {
            InitializeComponent();
        }
        public Patient_Menu_Form(int User_ID)
        {
            InitializeComponent();

            this.userId = User_ID;

            PatientDataAccess patientDataAccess = new PatientDataAccess();
            Patient patient = patientDataAccess.GetPatientByUserID(User_ID);
            Patient_ID_TextBox.Text = patient.Patient_ID.ToString();
            Patient_Email_TextBox.Text = patient.Email;
            Patient_Name_TextBox.Text = patient.Name;
            MobileTextBox.Text = patient.Mobile;
            BloodGroupTextBox.Text = patient.Blood_Group;
        }

        private void Patient_Menu_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();
            login_Form.Show();
        }

        private void Doctor_Button_Click(object sender, EventArgs e)
        {
            DoctorManage doctorManage = new DoctorManage();

            this.Hide();
            doctorManage.Show();
        }

        private void button5_Click(object sender, EventArgs e) //Test
        {
            SeeTest seeTest = new SeeTest();

            this.Hide();
            seeTest.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Read_Prescription read_Prescription = new Read_Prescription();

            this.Hide();
            read_Prescription.Show();
        }

        private void patientProfile1_Load(object sender, EventArgs e)
        {
            //patientProfile1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //patientProfile1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientRoom room = new PatientRoom();

            this.Hide();
            room.Show();
        }
    }
}
