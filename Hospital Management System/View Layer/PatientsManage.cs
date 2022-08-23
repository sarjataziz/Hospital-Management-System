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
    public partial class PatientsManage : Form
    {
        public PatientsManage()
        {
            InitializeComponent();

            PatientDataAccess patientDataAccess = new PatientDataAccess();
            Manage_Patients_DataGridView.DataSource = patientDataAccess.GetAllPatientsDetails();
        }

        private void PatientsManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PatientsManage_Logout_Button_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();
            login_Form.Show();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Doctor_Menu_Form doctor_Menu_Form = new Doctor_Menu_Form();

            this.Hide();
            doctor_Menu_Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Write_Prescription write_Prescription = new Write_Prescription();

            this.Hide();
            write_Prescription.Show();
        }

        void UpdateListOfPatients()
        {
            PatientDataAccess patientDataAccess = new PatientDataAccess();
            Manage_Patients_DataGridView.DataSource = patientDataAccess.GetAllPatientsDetails();
        }

        private void Manage_Patients_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            ID_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Patient_ID"].Value.ToString();
            Name_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Name"].Value.ToString();
            UsernameTextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Username"].Value.ToString();
            Password_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Password"].Value.ToString();
            UserIDTextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["User_ID"].Value.ToString();
            Email_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Email"].Value.ToString();
            Mobile_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Mobile"].Value.ToString();
            PatientDateTimePicker.Text = Manage_Patients_DataGridView.Rows[index].Cells["Date_of_Birth"].Value.ToString();;
            Address_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Address"].Value.ToString();
            BloodG_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Blood_Group"].Value.ToString();
            Gender_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Gender"].Value.ToString();
            Patients_Manage_DateTimePicker.Text = Manage_Patients_DataGridView.Rows[index].Cells["Accepted_Date"].Value.ToString();
        }

        private void AddNew_Patients_Info_Button_Click(object sender, EventArgs e)
        {
            try
            {
                PatientDataAccess newPatientDataAccess = new PatientDataAccess();

                Patient patient = new Patient();

                User user = new User();

                patient.Name = Name_Patients_Manage_TextBox.Text;
                patient.Email = Email_Patients_Manage_TextBox.Text;
                patient.Mobile = Mobile_Patients_Manage_TextBox.Text;
                patient.Date_of_Birth = Convert.ToDateTime(PatientDateTimePicker.Text);
                patient.Address = Address_Patients_Manage_TextBox.Text;
                patient.Blood_Group = BloodG_Patients_Manage_TextBox.Text;
                patient.Gender = Gender_Patients_Manage_TextBox.Text;
                patient.Accepted_Date = Convert.ToDateTime(Patients_Manage_DateTimePicker.Text);

                user.Username = Password_Patients_Manage_TextBox.Text;
                patient.User_ID = Int32.Parse(UserIDTextBox.Text);
                user.User_Type = "Patient";

                bool Issuccess = newPatientDataAccess.AddPatientsDetails(patient, user);

                if (Issuccess)
                {
                    MessageBox.Show("Successfully Patient Added.");
                    UpdateListOfPatients();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear_Patients_Info_Button_Click(object sender, EventArgs e)
        {
            ID_Patients_Manage_TextBox.Text = "";
            Name_Patients_Manage_TextBox.Text = "";
            Password_Patients_Manage_TextBox.Clear();
            Email_Patients_Manage_TextBox.Text = "";
            Mobile_Patients_Manage_TextBox.Text = "";
            PatientDateTimePicker.Text = "";
            Address_Patients_Manage_TextBox.Text = "";
            BloodG_Patients_Manage_TextBox.Text = "";
            Gender_Patients_Manage_TextBox.Text = "";
            Patients_Manage_DateTimePicker.Text = "";
        }

        private void Save_Patients_Info_Button_Click(object sender, EventArgs e)
        {
            try
            {
                PatientDataAccess patientDataAccess = new PatientDataAccess();

                Patient patient = new Patient();

                User user = new User();

                patient.Patient_ID = Int32.Parse(ID_Patients_Manage_TextBox.Text);
                patient.User_ID = Int32.Parse(UserIDTextBox.Text);
                patient.Name = Name_Patients_Manage_TextBox.Text;
                patient.Email = Email_Patients_Manage_TextBox.Text;
                patient.Mobile = Mobile_Patients_Manage_TextBox.Text;
                patient.Date_of_Birth = Convert.ToDateTime(PatientDateTimePicker.Text);
                patient.Address = Address_Patients_Manage_TextBox.Text;
                patient.Blood_Group = BloodG_Patients_Manage_TextBox.Text;
                patient.Gender = Gender_Patients_Manage_TextBox.Text;
                patient.Accepted_Date = Convert.ToDateTime(Patients_Manage_DateTimePicker.Text);
                user.Username = Password_Patients_Manage_TextBox.Text;

                bool Issuccess = patientDataAccess.GetPatientsUpdate(patient, user);

                if (Issuccess)
                {
                    MessageBox.Show("Successfully Patient Updated.");
                    UpdateListOfPatients();
                }
                else
                {
                    MessageBox.Show("Error in Update.", "Error");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_Patients_Manage_TextBox_TextChanged(object sender, EventArgs e)
        {
            PatientDataAccess patientDataAccess = new PatientDataAccess();

            Manage_Patients_DataGridView.DataSource = patientDataAccess.GetPatientsInSearch(Search_Patients_Manage_TextBox.Text);
        }
    }
}
