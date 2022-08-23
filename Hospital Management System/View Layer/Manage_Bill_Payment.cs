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
    public partial class Manage_Bill_Payment : Form
    {
        public Manage_Bill_Payment()
        {
            InitializeComponent();

            PaymentDataAccess paymentDataAccess = new PaymentDataAccess();
            Bill_Manage_DataGridView.DataSource = paymentDataAccess.GetAllPaymentDetails();
        }

        private void BillPayment_Back_Button_Click(object sender, EventArgs e)
        {
            Admin_Menu_Form admin_Menu_Form = new Admin_Menu_Form();

            this.Hide();
            admin_Menu_Form.Show();
        }

        private void Manage_Bill_Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BillPaymentLogouButton_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();
            login_Form.Show();
        }

        private void Bill_Manage_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                PaymentID_Manage_TextBox.Text = Bill_Manage_DataGridView.Rows[index].Cells["Payment_ID"].Value.ToString();
                TotalBill_Manage_TextBox.Text = Bill_Manage_DataGridView.Rows[index].Cells["Total_Bill"].Value.ToString();
                PaymentMethod_Manage_TextBox.Text = Bill_Manage_DataGridView.Rows[index].Cells["Payment_Method"].Value.ToString();
                PaymentDateManageDateTimePicker.Text = Bill_Manage_DataGridView.Rows[index].Cells["Payment_Date"].Value.ToString();
                Payment_PatientID_Manage_TextBox.Text = Bill_Manage_DataGridView.Rows[index].Cells["Patient_ID"].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void BillPayment_Clear_Button_Click(object sender, EventArgs e)
        {
            PaymentID_Manage_TextBox.Text = "";
            TotalBill_Manage_TextBox.Text = "";
            PaymentMethod_Manage_TextBox.Text = "";
            PaymentDateManageDateTimePicker.Text = "";
            Payment_PatientID_Manage_TextBox.Text = "";
        }

        private void Search_Bill_Manage_TextBox_TextChanged(object sender, EventArgs e)
        {
            PaymentDataAccess paymentDataAccess = new PaymentDataAccess();

            Bill_Manage_DataGridView.DataSource = paymentDataAccess.GetPaymentInSearch(Search_Bill_Manage_TextBox.Text);
        }
    }
}
