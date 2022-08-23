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
    public partial class Welcome_Form : Form
    {
        public Welcome_Form()
        {
            InitializeComponent();
        }

        private void Go_to_Login_Page_Button_Click(object sender, EventArgs e)
        {
            Login_Form loginForm = new Login_Form();

            this.Hide();
            loginForm.Show();
        }

        private void Welcome_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration_Form registrationForm = new Registration_Form();
            this.Hide();
            registrationForm.Show();
        }

        private void WeL_CancelPictureBox_Click_1(object sender, EventArgs e)
        {          
            Application.Exit();
        }

        private void WeL_Minimize_PictureBox_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
