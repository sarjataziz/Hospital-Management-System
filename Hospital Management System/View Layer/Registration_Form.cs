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
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Welcome_Form welcome_Form = new Welcome_Form();

            this.Hide();
            welcome_Form.Show();
        }

        private void Registration_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TermsAndConditionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TermsAndConditionCheckBox.Checked)
            {
                SinginButton.Enabled = true;
            }
            else
            {
                SinginButton.Enabled = false;                
            }
        }

        private void SinginButton_Click(object sender, EventArgs e)
        {
            if(UserRegistrationUsernameTextBox.Text == "")
            {
                MessageBox.Show("Username is Empty.");
            }
            else if (UserRegistrationPasswordTextBox.Text == "")
            {
                MessageBox.Show("Password is Empty.");
            }
            else
            {
                if (UserRegistrationPasswordTextBox.Text != UserRegistrationConfirmPTextBox.Text)
                {
                    MessageBox.Show("Password Doesn't Match.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TermsAndConditionCheckBox.Checked == false)
                {
                    MessageBox.Show("Please, Aggree our terms and Conditions.");
                }
                else
                {
                    User users = new User();

                    users.Username = UserRegistrationUsernameTextBox.Text;
                    users.Password = UserRegistrationPasswordTextBox.Text;

                    UserDataAccess userDataAccess = new UserDataAccess();

                    bool result = userDataAccess.Registration(users);

                    if (result)
                    {
                        MessageBox.Show("User added successfully.");

                        Login_Form login_Form = new Login_Form();
                        login_Form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error in registration.");
                    }
                }
            }
        }
    }
}
