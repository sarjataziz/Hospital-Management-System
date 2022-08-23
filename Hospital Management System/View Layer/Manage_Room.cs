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
    public partial class Manage_Room : Form
    {
        public Manage_Room()
        {
            InitializeComponent();

            RoomDataAccess roomDataAccess = new RoomDataAccess();

            Room_Manage_DataGridView.DataSource = roomDataAccess.GetRoomsDetails();

        }

        private void Manage_Room_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Room_Back_Button_Click(object sender, EventArgs e)
        {
            Admin_Menu_Form admin_Menu_Form = new Admin_Menu_Form();

            this.Hide();
            admin_Menu_Form.Show();
        }

        private void RoomLogouButton_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();
            login_Form.Show();
        }
        void UpdateListOfRoom()
        {
            RoomDataAccess roomDataAccess = new RoomDataAccess();

            Room_Manage_DataGridView.DataSource = roomDataAccess.GetRoomsDetails();
        }

        private void RoomManage_Add_Button_Click(object sender, EventArgs e)
        {
            try
            {
                RoomDataAccess roomDataAccess = new RoomDataAccess();

                Room room = new Room();

                room.Room_No = Int32.Parse(RoomNOTextBox.Text);
                room.Room_Type = RoomTypeTextBox.Text;
                room.Room_Cost = float.Parse(RoomCostTextBox.Text);
                room.Patient_ID = Int32.Parse(RoomPatientIDTextBox.Text);

                bool Issuccess = roomDataAccess.AddRoomDetails(room);

                if (Issuccess)
                {
                    MessageBox.Show("Successfully Room Added.");
                    UpdateListOfRoom();
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

        private void RoomManage_Clear_Button_Click(object sender, EventArgs e)
        {
            RoomIDTextBox.Text = "";
            RoomNOTextBox.Text = "";
            RoomTypeTextBox.Text = "";
            RoomCostTextBox.Text = "";
            RoomPatientIDTextBox.Text = "";
        }

        private void RoomManage_Save_Button_Click(object sender, EventArgs e)
        {
            try
            {
                RoomDataAccess roomDataAccess = new RoomDataAccess();

                Room room = new Room();

                room.Room_ID = Int32.Parse(RoomIDTextBox.Text);
                room.Room_No = Int32.Parse(RoomNOTextBox.Text);
                room.Room_Type = RoomTypeTextBox.Text;
                room.Room_Cost = float.Parse(RoomCostTextBox.Text);
                room.Patient_ID = Int32.Parse(RoomPatientIDTextBox.Text);

                bool Issuccess = roomDataAccess.GetRoomUpdate(room);

                if (Issuccess)
                {
                    MessageBox.Show("Successfully Room Updated.");
                    UpdateListOfRoom();
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

        private void RoomManage_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                RoomDataAccess roomDataAccess = new RoomDataAccess();

                Room room = roomDataAccess.GetRoomByID(Convert.ToInt32(RoomIDTextBox.Text));

                if (room != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        room = new Room();

                        if (roomDataAccess.DeleteRoomDetails(room.Room_ID))
                        {
                            MessageBox.Show("Room Information is delete.");
                            UpdateListOfRoom();
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

        private void Search_Room_Manage_TextBox_TextChanged(object sender, EventArgs e)
        {
            RoomDataAccess roomDataAccess = new RoomDataAccess();

            Room_Manage_DataGridView.DataSource = roomDataAccess.GetRoomInSearch(Search_Room_Manage_TextBox.Text);
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
                RoomPatientIDTextBox.Text = Room_Manage_DataGridView.Rows[index].Cells["Patient_ID"].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
    }
}
