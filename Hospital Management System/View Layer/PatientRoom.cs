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
    public partial class PatientRoom : Form
    {
        public PatientRoom()
        {
            InitializeComponent();

            RoomDataAccess roomDataAccess = new RoomDataAccess();

            Room_Manage_DataGridView.DataSource = roomDataAccess.GetRoomDetails();
        }

        private void PatientRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Room_Back_Button_Click(object sender, EventArgs e)
        {
            Patient_Menu_Form patient_Menu_Form = new Patient_Menu_Form();

            this.Hide();
            patient_Menu_Form.Show();
        }

        private void RoomLogouButton_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();
            login_Form.Show();
        }

        private void Room_Manage_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                RoomIDTextBox.Text = Room_Manage_DataGridView.Rows[index].Cells["Room_ID"].Value.ToString();
                RoomNOTextBox.Text = Room_Manage_DataGridView.Rows[index].Cells["Room_No"].Value.ToString();
                RoomTypeTextBox.Text = Room_Manage_DataGridView.Rows[index].Cells["Room_Type"].Value.ToString();
                RoomCostTextBox.Text = Room_Manage_DataGridView.Rows[index].Cells["Room_Cost"].Value.ToString();
                //RoomPatientIDTextBox.Text = Room_Manage_DataGridView.Rows[index].Cells["Patient_ID"].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_Room_Manage_TextBox_TextChanged(object sender, EventArgs e)
        {
            RoomDataAccess roomDataAccess = new RoomDataAccess();

            Room_Manage_DataGridView.DataSource = roomDataAccess.GetRoomInSearch(Search_Room_Manage_TextBox.Text);
        }
    }
}
