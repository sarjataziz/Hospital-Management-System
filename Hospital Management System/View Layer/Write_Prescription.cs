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
using System.Windows.Forms;

namespace Hospital_Management_System.View_Layer
{
    public partial class Write_Prescription : Form
    {
        public Write_Prescription()
        {
            InitializeComponent();

            PrescriptionDataAccess prescriptionDataAccess = new PrescriptionDataAccess();

            Manage_Patients_DataGridView.DataSource = prescriptionDataAccess.GetAllPrescriptionDetails();
        }

        private void Write_Prescription_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();
            login_Form.Show();
        }

        private void Back_Prescription_Button_Click(object sender, EventArgs e)
        {
            Doctor_Menu_Form doctor_Menu_Form = new Doctor_Menu_Form();

            this.Hide();
            doctor_Menu_Form.Show();
        }

        void UpdateListOfPrescriptionts()
        {
            PrescriptionDataAccess prescriptionDataAccess = new PrescriptionDataAccess();

            Manage_Patients_DataGridView.DataSource = prescriptionDataAccess.GetAllPrescriptionDetails();
        }

        private void Manage_Patients_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                ID_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Patient_ID"].Value.ToString();
                Name_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Name"].Value.ToString();
                PID_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Prescription_ID"].Value.ToString();
                SicknessTextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Sickness"].Value.ToString();
                Gender_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Gender"].Value.ToString();
                WPrescriptionTextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Prescription_Details"].Value.ToString();
                BloodG_Patients_Manage_TextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Blood_Group"].Value.ToString();
                DITextBox.Text = Manage_Patients_DataGridView.Rows[index].Cells["Doctor_ID"].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNew_Patients_Info_Button_Click(object sender, EventArgs e)
        {
            try
            {
                PrescriptionDataAccess prescriptionDataAccess = new PrescriptionDataAccess();

                Prescription prescription = new Prescription();

                prescription.Patient_ID = Int32.Parse(ID_Patients_Manage_TextBox.Text);
                prescription.Name = Name_Patients_Manage_TextBox.Text;
                prescription.Prescription_ID = Int32.Parse(PID_Manage_TextBox.Text);
                prescription.Sickness = SicknessTextBox.Text;
                prescription.Gender = Gender_Patients_Manage_TextBox.Text;
                prescription.Blood_Group = BloodG_Patients_Manage_TextBox.Text;
                prescription.Prescription_Details = WPrescriptionTextBox.Text;
                prescription.Doctor_ID = Int32.Parse(DITextBox.Text);

                bool Issuccess = prescriptionDataAccess.AddPrescriptionDetails(prescription);

                if (Issuccess)
                {
                    MessageBox.Show("Successfully Patient Added.");
                    UpdateListOfPrescriptionts();
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
            PID_Manage_TextBox.Text = "";
            SicknessTextBox.Text ="";
            Gender_Patients_Manage_TextBox.Text = "";
            WPrescriptionTextBox.Text = "";
            BloodG_Patients_Manage_TextBox.Text = "";
        }

        private void Save_Patients_Info_Button_Click(object sender, EventArgs e)
        {
            try
            {
                PrescriptionDataAccess prescriptionDataAccess = new PrescriptionDataAccess();

                Prescription prescription = new Prescription();

                prescription.Patient_ID = Int32.Parse(ID_Patients_Manage_TextBox.Text);
                prescription.Name = Name_Patients_Manage_TextBox.Text;
                prescription.Prescription_ID = Int32.Parse(PID_Manage_TextBox.Text);
                prescription.Sickness = SicknessTextBox.Text;
                prescription.Gender = Gender_Patients_Manage_TextBox.Text;
                prescription.Blood_Group = BloodG_Patients_Manage_TextBox.Text;
                prescription.Prescription_Details = WPrescriptionTextBox.Text;
                prescription.Doctor_ID = Int32.Parse(DITextBox.Text);

                bool Issuccess = prescriptionDataAccess.GetPrescriptionUpdate(prescription);

                if (Issuccess)
                {
                    MessageBox.Show("Successfully Prescription Updated.");
                    UpdateListOfPrescriptionts();
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

        private void Search_Prescriptions_Manage_TextBox_TextChanged(object sender, EventArgs e)
        {
            PrescriptionDataAccess prescriptionDataAccess = new PrescriptionDataAccess();

            Manage_Patients_DataGridView.DataSource = prescriptionDataAccess.GetPrescriptionInSearch(Search_Prescriptions_Manage_TextBox.Text);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                PrescriptionDataAccess prescriptionDataAccess = new PrescriptionDataAccess(); ;

                Prescription prescription = prescriptionDataAccess.GetPrescriptionsByID(Convert.ToInt32(PID_Manage_TextBox.Text));

                if (prescription != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        prescriptionDataAccess = new PrescriptionDataAccess();

                        if (prescriptionDataAccess.DeletePrescriptionDetails(prescription.Prescription_ID))
                        {
                            MessageBox.Show("Prescription Information is delete.");
                            UpdateListOfPrescriptionts();
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
    }
}
