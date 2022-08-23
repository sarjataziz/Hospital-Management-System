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
    public partial class Doctor_Department : Form
    {
        public Doctor_Department()
        {
            InitializeComponent();

            DepartmentDataAccess departmentDataAccess = new DepartmentDataAccess();

            Department_Manage_DataGridView.DataSource = departmentDataAccess.GetDepartmentsDetails();
        }

        private void Room_Back_Button_Click(object sender, EventArgs e)
        {
            Doctor_Menu_Form doctor_Menu_Form = new Doctor_Menu_Form();

            this.Hide();
            doctor_Menu_Form.Show();
        }

        private void DepartmentLogouButton_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();
            login_Form.Show();
        }

        private void Doctor_Department_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Department_Manage_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                DepartmentManageIDTextBox.Text = Department_Manage_DataGridView.Rows[index].Cells["Department_ID"].Value.ToString();
                DepartmentNameManageTextBox.Text = Department_Manage_DataGridView.Rows[index].Cells["Department_Name"].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_Department_Manage_TextBox_TextChanged(object sender, EventArgs e)
        {
            DepartmentDataAccess departmentDataAccess = new DepartmentDataAccess();

            Department_Manage_DataGridView.DataSource = departmentDataAccess.GetDepartmentInSearch(Search_Department_Manage_TextBox.Text);
        }
    }
}
