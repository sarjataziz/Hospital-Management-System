using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Management_System.User_Data_Access;
using Hospital_Management_System.Users;

namespace Hospital_Management_System.View_Layer
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Go_To_Back_Login_Button_Click(object sender, EventArgs e)
        {
            Welcome_Form welcome_Form = new Welcome_Form();

            this.Hide();
            welcome_Form.Show();
        }

        private void User_Login_Button_Click(object sender, EventArgs e)
        {
            UserDataAccess userDataAccess = new UserDataAccess();

            if (Username_TextBox.Text == "" && User_Password_TextBox.Text == "")
            {
                MessageBox.Show("Username or Password in Empty","Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            User user = userDataAccess.LoginValidation(Username_TextBox.Text, User_Password_TextBox.Text);
            //string user = userDataAccess.LoginValidation(Username_TextBox.Text, User_Password_TextBox.Text);

            if (user != null)
            {
                if (user.User_Type == "Doctor")
                {
                    Doctor_Menu_Form doctor_Menu_Form = new Doctor_Menu_Form(user.User_ID);

                    this.Hide();
                    doctor_Menu_Form.Show();
                }
                else if(user.User_Type == "Patient")
                {
                    Patient_Menu_Form patient_Menu_Form = new Patient_Menu_Form(user.User_ID);

                    this.Hide();
                    patient_Menu_Form.Show();
                }
                else if (user.User_Type == "Admin")
                {
                    Admin_Menu_Form menu_Form = new Admin_Menu_Form(user.User_ID);

                    this.Hide();
                    menu_Form.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User Type.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password."+ user , "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Username_TextBox.Clear();
                User_Password_TextBox.Clear();
                Username_TextBox.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Show_Password_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            User_Password_TextBox.PasswordChar = Show_Password_CheckBox.Checked ? '\0' : '*';
        }

        private void ChangePasswordLabel_Click(object sender, EventArgs e)
        {
            Change_Password change_Password = new Change_Password();

            this.Hide();

            change_Password.Show();
        }

        private void GoToRegistrationFrom_Lebel_Click(object sender, EventArgs e)
        {
            Registration_Form registration_Form = new Registration_Form();

            this.Hide();
            registration_Form.Show();
        }
    }
}
