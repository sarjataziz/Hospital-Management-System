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
    public partial class Manage_Test : Form
    {
        public Manage_Test()
        {
            InitializeComponent();

            TestDataAccess testDataAccess = new TestDataAccess();

            Manage_Test_DataGridView.DataSource = testDataAccess.GetTestsDetails();
        }

        private void TestManage_Logout_Button_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();
            login_Form.Show();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Admin_Menu_Form admin_Menu_Form = new Admin_Menu_Form();

            this.Hide();
            admin_Menu_Form.Show();
        }

        private void Manage_Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        void UpdateListOfDepartment()
        {
            TestDataAccess testDataAccess = new TestDataAccess();

            Manage_Test_DataGridView.DataSource = testDataAccess.GetTestsDetails();
        }

        private void AddNew_Test_Info_Button_Click(object sender, EventArgs e)
        {
            try
            {
                TestDataAccess testDataAccess = new TestDataAccess();

                Test test = new Test();

                test.Test_Name = Name_Test_Manage_TextBox.Text;
                test.Date = Convert.ToDateTime(PatientDateTimePicker.Text);
                test.Recives_Date = Convert.ToDateTime(RecivedTest_DateTimePicker.Text);
                test.Fee = Convert.ToInt32(Fee_Test_Manage_TextBox.Text);
                test.Patient_ID = Convert.ToInt32(PID_Test_Manage_TextBox.Text);

                bool Issuccess = testDataAccess.AddTestsDetails(test);

                if (Issuccess)
                {
                    MessageBox.Show("Successfully Added.");
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

        private void Clear_Test_Info_Button_Click(object sender, EventArgs e)
        {
            ID_Test_Manage_TextBox.Text = "";
            Name_Test_Manage_TextBox.Text = "";
            PatientName_Test_Manage_TextBox.Text = "";
            PID_Test_Manage_TextBox.Text = "";
            PatientDateTimePicker.Text = "";
            RecivedTest_DateTimePicker.Text = "";
            Fee_Test_Manage_TextBox.Text = "";
        }

        private void Save_Test_Info_Button_Click(object sender, EventArgs e)
        {
            try
            {
                TestDataAccess testDataAccess = new TestDataAccess();

                Test test = new Test();

                test.Test_ID = Convert.ToInt32(ID_Test_Manage_TextBox.Text);
                test.Test_Name = Name_Test_Manage_TextBox.Text;
                test.Date = Convert.ToDateTime(PatientDateTimePicker.Text);
                test.Recives_Date = Convert.ToDateTime(RecivedTest_DateTimePicker.Text);
                test.Fee = Convert.ToInt32(Fee_Test_Manage_TextBox.Text);
                test.Patient_ID = Convert.ToInt32(PID_Test_Manage_TextBox.Text);

                bool Issuccess = testDataAccess.GetTestsUpdate(test);

                if (Issuccess)
                {
                    MessageBox.Show("Successfully Updated.");
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

        private void Delete_Tests_Button_Click(object sender, EventArgs e)
        {
            try
            {
                TestDataAccess testDataAccess = new TestDataAccess();

                Test test = testDataAccess.GetTestsByID(Convert.ToInt32(ID_Test_Manage_TextBox.Text));

                if (test != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        testDataAccess = new TestDataAccess();

                        if (testDataAccess.DeleteTestsDetails(test.Test_ID))
                        {
                            MessageBox.Show("Test Information is delete.");
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

        private void Manage_Test_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                ID_Test_Manage_TextBox.Text = Manage_Test_DataGridView.Rows[index].Cells["Test_ID"].Value.ToString();
                Name_Test_Manage_TextBox.Text = Manage_Test_DataGridView.Rows[index].Cells["Test_Name"].Value.ToString();
                PatientName_Test_Manage_TextBox.Text = Manage_Test_DataGridView.Rows[index].Cells["Name"].Value.ToString();
                PID_Test_Manage_TextBox.Text = Manage_Test_DataGridView.Rows[index].Cells["Patient_ID"].Value.ToString();
                PatientDateTimePicker.Text = Manage_Test_DataGridView.Rows[index].Cells["Date"].Value.ToString();
                RecivedTest_DateTimePicker.Text = Manage_Test_DataGridView.Rows[index].Cells["Recives_Date"].Value.ToString();
                Fee_Test_Manage_TextBox.Text = Manage_Test_DataGridView.Rows[index].Cells["Fee"].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void Search_Test_Manage_TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TestDataAccess testDataAccess = new TestDataAccess();

                Manage_Test_DataGridView.DataSource = testDataAccess.GetTestsInSearch(Search_Test_Manage_TextBox.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
    }
}
