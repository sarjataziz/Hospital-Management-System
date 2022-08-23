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
    public partial class Manage_Department : Form
    {
        public Manage_Department()
        {
            InitializeComponent();

            DepartmentDataAccess departmentDataAccess = new DepartmentDataAccess();

            Department_Manage_DataGridView.DataSource = departmentDataAccess.GetDepartmentsDetails();
        }

        private void Room_Back_Button_Click(object sender, EventArgs e)
        {
            Admin_Menu_Form admin_Menu_Form = new Admin_Menu_Form();

            this.Hide();
            admin_Menu_Form.Show();
        }

        private void Manage_Department_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DepartmentLogouButton_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();
            login_Form.Show();
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

        void UpdateListOfDepartment()
        {
            DepartmentDataAccess departmentDataAccess = new DepartmentDataAccess();

            Department_Manage_DataGridView.DataSource = departmentDataAccess.GetDepartmentsDetails();
        }

        private void DepartmentManage_Add_Button_Click(object sender, EventArgs e)
        {
            try
            {
                DepartmentDataAccess departmentDataAccess = new DepartmentDataAccess();

                Department department = new Department();

                department.Department_Name = DepartmentNameManageTextBox.Text;

                bool Issuccess = departmentDataAccess.AddDepartmentDetails(department);

                if (Issuccess)
                {
                    MessageBox.Show("Successfully Department Added.");
                    UpdateListOfDepartment();
                }
                else
                {
                    MessageBox.Show("Error in Adding");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void DepartmentManage_Clear_Button_Click(object sender, EventArgs e)
        {
            DepartmentManageIDTextBox.Text = "";
            DepartmentNameManageTextBox.Text = "";
        }

        private void DepartmentManage_Save_Button_Click(object sender, EventArgs e)
        {
            try
            {
                DepartmentDataAccess departmentDataAccess = new DepartmentDataAccess();

                Department department = new Department();

                department.Department_ID = Int32.Parse(DepartmentManageIDTextBox.Text);
                department.Department_Name = DepartmentNameManageTextBox.Text;

                bool Issuccess = departmentDataAccess.GetDepartmentUpdate(department);

                if (Issuccess)
                {
                    MessageBox.Show("Successfully Department Updated.");
                    UpdateListOfDepartment();
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

        private void DepartmentManage_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                DepartmentDataAccess departmentDataAccess = new DepartmentDataAccess();

                Department department = departmentDataAccess.GetDepartmentByID(Convert.ToInt32(DepartmentManageIDTextBox.Text));

                if (department != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        departmentDataAccess = new DepartmentDataAccess();

                        if (departmentDataAccess.DeleteDepartmentDetails(department.Department_ID))
                        {
                            MessageBox.Show("Department Information is delete.");
                            UpdateListOfDepartment();
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

        private void Search_Department_Manage_TextBox_TextChanged(object sender, EventArgs e)
        {          
            DepartmentDataAccess departmentDataAccess = new DepartmentDataAccess();

            Department_Manage_DataGridView.DataSource = departmentDataAccess.GetDepartmentInSearch(Search_Department_Manage_TextBox.Text);
        }
    }
}
