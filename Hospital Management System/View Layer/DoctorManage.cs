using Hospital_Management_System.User_Data_Access;
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
    public partial class DoctorManage : Form
    {
        public DoctorManage()
        {
            InitializeComponent();

            AppoinmentDataAccess appoinmentDataAccess = new AppoinmentDataAccess();
            Doctors_DataGridView.DataSource = appoinmentDataAccess.GetAppointmentInfo();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Patient_Menu_Form patient_Menu_Form = new Patient_Menu_Form();

            this.Hide();
            patient_Menu_Form.Show();
        }

        private void DoctorManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PatientsManage_Logout_Button_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();
            login_Form.Show();
        }

        private void Manage_Doctors_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                ID_Doctor_Manage_TextBox.Text = Doctors_DataGridView.Rows[index].Cells["Doctor_ID"].Value.ToString();
                Name_Doctor_Manage_TextBox.Text = Doctors_DataGridView.Rows[index].Cells["Name"].Value.ToString();
                Email_Doctor_Manage_TextBox.Text = Doctors_DataGridView.Rows[index].Cells["Email"].Value.ToString();
                Mobile_Doctor_Manage_TextBox.Text = Doctors_DataGridView.Rows[index].Cells["Mobile"].Value.ToString();
                Doctor_Manage_DateTimePicker.Text = Doctors_DataGridView.Rows[index].Cells["Accepted_Date"].Value.ToString();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
