using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Management_System.User_Data_Access;
using Hospital_Management_System.Users;


namespace Hospital_Management_System.View_Layer
{
    public partial class Manage_Patients : Form
    {
        public Manage_Patients()
        {
            InitializeComponent();

            PatientDataAccess patientDataAccess = new PatientDataAccess();
            Manage_Patients_DataGridView.DataSource = patientDataAccess.GetAllPatientsDetails();
        }

        private void Back_Patients_Manage_Button_Click(object sender, EventArgs e)
        {
            Admin_Menu_Form admin_Menu_Form = new Admin_Menu_Form();

            this.Hide();
            admin_Menu_Form.Show();
        }

        private void Patients_Manage_Logout_Button_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form(); 

            this.Hide();
            login_Form.Show();
        }

        void UpdateListOfPatients()
        {
            PatientDataAccess patientDataAccess = new PatientDataAccess();
            Manage_Patients_DataGridView.DataSource = patientDataAccess.GetAllPatientsDetails();
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
                patient.Nationality = Nationality_Patients_Manage_TextBox.Text;
                patient.Address = Address_Patients_Manage_TextBox.Text;
                patient.Blood_Group = BloodG_Patients_Manage_TextBox.Text;
                patient.Gender = Gender_Patients_Manage_TextBox.Text;
                patient.Accepted_Date = Convert.ToDateTime(Patients_Manage_DateTimePicker.Text);

                user.Username = Username_Patients_Manage_TextBox.Text;
                user.Password = Password_Patients_Manage_TextBox.Text;
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

        private void Manage_Patients_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                ID_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Patient_ID"].Value.ToString();
                Name_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Name"].Value.ToString();
                Username_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Username"].Value.ToString();
                Email_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Email"].Value.ToString();
                Mobile_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Mobile"].Value.ToString();
                PatientDateTimePicker.Text = Manage_Patients_DataGridView.Rows[index].Cells["Date_of_Birth"].Value.ToString();
                Nationality_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Nationality"].Value.ToString();
                Address_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Address"].Value.ToString();
                BloodG_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Blood_Group"].Value.ToString();
                Gender_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Gender"].Value.ToString();
                Patients_Manage_DateTimePicker.Text = Manage_Patients_DataGridView.Rows[index].Cells["Accepted_Date"].Value.ToString();
                UserIDTextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["User_ID"].Value.ToString();
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

        private void Clear_Patients_Info_Button_Click(object sender, EventArgs e)
        {
            ID_Patients_Manage_TextBox.Text = "";
            Name_Patients_Manage_TextBox.Text = "";
            Username_Patients_Manage_TextBox.Clear();
            Password_Patients_Manage_TextBox.Clear();
            Email_Patients_Manage_TextBox.Text = "";
            Mobile_Patients_Manage_TextBox.Text = "";
            PatientDateTimePicker.Text = "";
            Nationality_Patients_Manage_TextBox.Text = "";
            Address_Patients_Manage_TextBox.Text = "";
            BloodG_Patients_Manage_TextBox.Text = "";
            Gender_Patients_Manage_TextBox.Text = "";
            Patients_Manage_DateTimePicker.Text = "";
            UserIDTextBox.Text = "";
        }

        private void Delete_Patients_Info_Button_Click(object sender, EventArgs e)
        {
            try
            {
                PatientDataAccess patientDataAccess = new PatientDataAccess();

                Patient patient = patientDataAccess.GetPatientsByID(Convert.ToInt32(ID_Patients_Manage_TextBox.Text));

                if (patient != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        patientDataAccess = new PatientDataAccess();

                        if (patientDataAccess.DeletePatientsDetails(patient.Patient_ID))
                        {
                            MessageBox.Show("Patient Information is delete.");
                            UpdateListOfPatients();
                        }
                        else
                        {
                            MessageBox.Show("Error in Deleting.");
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void Save_Patients_Info_Button_Click(object sender, EventArgs e)
        {
            try
            {
                PatientDataAccess patientDataAccess = new PatientDataAccess();

                Patient patient = new Patient();

                User user = new User();

                patient.Patient_ID = Int32.Parse(ID_Patients_Manage_TextBox.Text);
                patient.Name = Name_Patients_Manage_TextBox.Text;
                //patient.User_ID = Int32.Parse(Username_Patients_Manage_TextBox);
                patient.Email = Email_Patients_Manage_TextBox.Text;
                patient.Mobile = Mobile_Patients_Manage_TextBox.Text;
                patient.Date_of_Birth = Convert.ToDateTime(PatientDateTimePicker.Text);
                patient.Nationality = Nationality_Patients_Manage_TextBox.Text;
                patient.Address = Address_Patients_Manage_TextBox.Text;
                patient.Blood_Group = BloodG_Patients_Manage_TextBox.Text;
                patient.Gender = Gender_Patients_Manage_TextBox.Text;
                patient.Accepted_Date = Convert.ToDateTime(Patients_Manage_DateTimePicker.Text);

                user.User_ID = Int32.Parse(UserIDTextBox.Text);
                user.Username = Username_Patients_Manage_TextBox.Text;

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
    }
}
