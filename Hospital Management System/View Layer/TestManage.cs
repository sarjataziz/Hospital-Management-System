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
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Hospital_Management_System.View_Layer
{
    public partial class TestManage : Form
    {
        public TestManage()
        {
            InitializeComponent();

            TestDataAccess testDataAccess = new TestDataAccess();

            Test_DataGridView.DataSource = testDataAccess.GetTestsDetails();
        }

        private void TestManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TestManage_Logout_Button_Click(object sender, EventArgs e)
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
        void UpdateListOfDepartment()
        {
            TestDataAccess testDataAccess = new TestDataAccess();

            Test_DataGridView.DataSource = testDataAccess.GetTestsDetails();
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
                test.Patient_ID = Convert.ToInt32(PatientID_Test_Manage_TextBox.Text);
                //test.Name = PatientName_Test_Manage_TextBox.Text;

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
            PatientName_Tests_Manage_TextBox.Text = "";
            PatientID_Test_Manage_TextBox.Text = "";
            PatientDateTimePicker.Text = "";
            RecivedTest_DateTimePicker.Text = "";
            Fee_Test_Manage_TextBox.Text = "";
        }

        private void Save_Test_Info_Button_Click(object sender, EventArgs e)
        {
            try
            {
                TestDataAccess testDataAccess = new TestDataAccess();
                Test tests = new Test();

                tests.Test_ID = Convert.ToInt32(ID_Test_Manage_TextBox.Text);
                tests.Test_Name = Name_Test_Manage_TextBox.Text;
                tests.Date = Convert.ToDateTime(PatientDateTimePicker.Text);
                tests.Recives_Date = Convert.ToDateTime(RecivedTest_DateTimePicker.Text);
                tests.Patient_ID = Convert.ToInt32(PatientID_Test_Manage_TextBox.Text);
                tests.Fee = Convert.ToInt32(Fee_Test_Manage_TextBox.Text);

                bool Issuccess = testDataAccess.GetTestsUpdate(tests);

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

        private void Delete_Test_Button_Click(object sender, EventArgs e)
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

        private void Test_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                ID_Test_Manage_TextBox.Text = Test_DataGridView.Rows[index].Cells["Test_ID"].Value.ToString();
                Name_Test_Manage_TextBox.Text = Test_DataGridView.Rows[index].Cells["Test_Name"].Value.ToString();
                PatientName_Tests_Manage_TextBox.Text = Test_DataGridView.Rows[index].Cells["Name"].Value.ToString();
                PatientID_Test_Manage_TextBox.Text = Test_DataGridView.Rows[index].Cells["Patient_ID"].Value.ToString();
                PatientDateTimePicker.Text = Test_DataGridView.Rows[index].Cells["Date"].Value.ToString();
                RecivedTest_DateTimePicker.Text = Test_DataGridView.Rows[index].Cells["Recives_Date"].Value.ToString();
                Fee_Test_Manage_TextBox.Text = Test_DataGridView.Rows[index].Cells["Fee"].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }             
        }

        private void Search_Test_Manage_TextBox_TextChanged(object sender, EventArgs e)
        {
            TestDataAccess testDataAccess = new TestDataAccess();

            Test_DataGridView.DataSource = testDataAccess.GetTestsInSearch(Search_Test_Manage_TextBox.Text);
        }
    }
}
