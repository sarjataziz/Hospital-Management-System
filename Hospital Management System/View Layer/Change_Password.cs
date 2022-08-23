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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hospital_Management_System.View_Layer
{
    public partial class Change_Password : Form
    {
        public Change_Password()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();
            login_Form.Show();
        }

        private void Change_Password_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PasswordConfirmButton_Click(object sender, EventArgs e)
        {
            UserDataAccess userDataAccess = new UserDataAccess();

            User users = new User();

            if (NewPasswordTextBox.Text == ConfirmPasswordTextBox.Text)
            {
                users.Username = UsernameORUserIDTextBox.Text;
                users.Password = NewPasswordTextBox.Text;

                bool result = userDataAccess.ChangePassword(users);

                if (result)
                {
                    MessageBox.Show("Updated.");
                }
                else
                {
                    MessageBox.Show("Error.");
                }
            }
        }

        private void Show_Password_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            NewPasswordTextBox.PasswordChar = Show_Password_CheckBox.Checked ? '\0' : '*';
            ConfirmPasswordTextBox.PasswordChar = Show_Password_CheckBox.Checked ? '\0' : '*';
        }
    }
}
