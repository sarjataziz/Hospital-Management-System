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
    public partial class Read_Prescription : Form
    {
        public Read_Prescription()
        {
            InitializeComponent();
        }

        private void Read_Prescription_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Prescription_Button_Click(object sender, EventArgs e)
        {
            Patient_Menu_Form patient_Menu_Form = new Patient_Menu_Form();

            this.Hide();
            patient_Menu_Form.Show();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();
            login_Form.Show();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Patient_Menu_Form patient_Menu_Form = new Patient_Menu_Form();

            this.Hide();
            patient_Menu_Form.Show();
        }

        private void Logout_Button_Click_1(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();
            login_Form.Show();
        }
    }
}
