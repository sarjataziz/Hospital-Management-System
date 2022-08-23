using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Management_System.User_Data_Access;
using System.Windows.Forms;
using Hospital_Management_System.Users;
using System.Drawing.Imaging;
using System.IO;
using System.Data.SqlClient;

namespace Hospital_Management_System.View_Layer
{
    public partial class Manage_Doctors : Form
    {
        public Manage_Doctors()
        {
            InitializeComponent();

            DoctorDataAccess doctorDataAccess = new DoctorDataAccess();
            Manage_Doctors_DataGridView.DataSource = doctorDataAccess.GetAllDoctorDetails();
        }

        private void Manage_Doctors_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Doctor_Manage_Logout_Button_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();

            this.Hide();

            login_Form.Show();
        }

        private void Back_Doctor_Manage_Button_Click(object sender, EventArgs e)
        {
            Admin_Menu_Form menu_Form = new Admin_Menu_Form();

            this.Hide();
            menu_Form.Show();
        }


        void UpdateListOfDoctor()
        {
            DoctorDataAccess doctorDataAccess = new DoctorDataAccess();
            Manage_Doctors_DataGridView.DataSource = doctorDataAccess.GetAllDoctorDetails(); 
        }

        private void AddNew_Doctor_Info_Button_Click(object sender, EventArgs e)
        {
            try
            {

                DoctorDataAccess newDoctorDataAccess = new DoctorDataAccess();

                Doctor doctors = new Doctor();

                User user = new User();

                doctors.Name = Doctor_Name_Manage_TextBox.Text;
                //doctors.User_ID = Int32.Parse(Doctor_Usernmae_Manage_TextBox);
                doctors.Email = Doctor_Email_Manage_TextBox.Text;
                doctors.Mobile = Doctor_Mobile_Manage_TextBox.Text;
                doctors.Date_of_Birth = Convert.ToDateTime(Doctor_Manage_DateTimePicker.Text);
                doctors.Nationality = Doctor_Nationality_Manage_TextBox.Text;
                doctors.Address = Doctor_Address_Manage_TextBox.Text;
                doctors.Blood_Group = Doctor_Manage_BloodG_ComboBox.Text;
                doctors.Gender = Doctor_Manage_Gender_ComboBox.Text;
                doctors.Salary = Convert.ToDouble(Doctor_Salary_Manage_TextBox.Text);
                doctors.Experience = Doctor_Experience_Manage_TextBox.Text;
                //doctors.Doctor_Image = Doctor_Manage_PictureBox1.Text;

                user.Username = Doctor_Usernmae_Manage_TextBox.Text;
                user.Password = Doctor_Password_Manage_TextBox.Text;
                user.User_Type = "Doctor";

                string Department_Name = Doctor_Department_Manage_ComboBox.Text;

                bool Issuccess = newDoctorDataAccess.AddDoctorDetails(doctors, user, Department_Name);

                if (Issuccess)
                {
                    MessageBox.Show("Successfully Doctor Added.");
                    UpdateListOfDoctor();
                }
                else
                {
                    MessageBox.Show("Error in Adding.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Manage_Doctors_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                Doctor_ID_Manage_TextBox.Text = Manage_Doctors_DataGridView.Rows[index].Cells["Doctor_ID"].Value.ToString();
                Doctor_Name_Manage_TextBox.Text = Manage_Doctors_DataGridView.Rows[index].Cells["Name"].Value.ToString();
                Doctor_Usernmae_Manage_TextBox.Text = Manage_Doctors_DataGridView.Rows[index].Cells["Username"].Value.ToString();
                UserID_TextBox.Text = Manage_Doctors_DataGridView.Rows[index].Cells["User_ID"].Value.ToString();
                Doctor_Email_Manage_TextBox.Text = Manage_Doctors_DataGridView.Rows[index].Cells["Email"].Value.ToString();
                Doctor_Mobile_Manage_TextBox.Text = Manage_Doctors_DataGridView.Rows[index].Cells["Mobile"].Value.ToString();
                Doctor_Manage_DateTimePicker.Text = Manage_Doctors_DataGridView.Rows[index].Cells["Date_of_Birth"].Value.ToString();
                Doctor_Nationality_Manage_TextBox.Text = Manage_Doctors_DataGridView.Rows[index].Cells["Nationality"].Value.ToString();
                Doctor_Address_Manage_TextBox.Text = Manage_Doctors_DataGridView.Rows[index].Cells["Address"].Value.ToString();
                Doctor_Manage_BloodG_ComboBox.Text = Manage_Doctors_DataGridView.Rows[index].Cells["Blood_Group"].Value.ToString();
                Doctor_Manage_Gender_ComboBox.Text = Manage_Doctors_DataGridView.Rows[index].Cells["Gender"].Value.ToString();
                Doctor_Salary_Manage_TextBox.Text = Manage_Doctors_DataGridView.Rows[index].Cells["Salary"].Value.ToString();
                Doctor_Experience_Manage_TextBox.Text = Manage_Doctors_DataGridView.Rows[index].Cells["Experience"].Value.ToString();
                Doctor_Department_Manage_ComboBox.Text = Manage_Doctors_DataGridView.Rows[index].Cells["Department_Name"].Value.ToString();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Search_Doctor_Manage_TextBox_TextChanged(object sender, EventArgs e)
        {
            DoctorDataAccess doctorDataAccess = new DoctorDataAccess();

            Manage_Doctors_DataGridView.DataSource = doctorDataAccess.GetDoctorInSearch(Search_Doctor_Manage_TextBox.Text);
        }

        private void Delete_Doctor_Info_Button_Click(object sender, EventArgs e)
        {
            try
            {
                DoctorDataAccess doctorDataAccess = new DoctorDataAccess();

                Doctor doctor = doctorDataAccess.GetDoctorByID(Convert.ToInt32(Doctor_ID_Manage_TextBox.Text));

                if (doctor != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        doctorDataAccess = new DoctorDataAccess();

                        if (doctorDataAccess.DeleteDoctorDetails(doctor.Doctor_ID))
                        {
                            MessageBox.Show("Doctor Information is delete.");
                            UpdateListOfDoctor();
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
/*        void ConvertImage()
        {
            if (Doctor_Manage_PictureBox1 != null)
            {
                MemoryStream memoryStream = new MemoryStream();

                Doctor_Manage_PictureBox1.Image.Save(memoryStream, Doctor_Manage_PictureBox1.Image.RawFormat);
            }               
        }*/
        /*byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                img.Save(memoryStream, ImageFormat.Jpeg);
                return memoryStream.ToArray();
            }

        }*/

        private void Save_Doctor_Info_Button_Click(object sender, EventArgs e)
        {
            try
            {
                DoctorDataAccess newDoctorDataAccess = new DoctorDataAccess();

                Doctor doctors = new Doctor();

                User user = new User();

                doctors.Doctor_ID = Int32.Parse(Doctor_ID_Manage_TextBox.Text);
                doctors.Name = Doctor_Name_Manage_TextBox.Text;
                doctors.Email = Doctor_Email_Manage_TextBox.Text;
                doctors.Mobile = Doctor_Mobile_Manage_TextBox.Text;
                doctors.Date_of_Birth = Convert.ToDateTime(Doctor_Manage_DateTimePicker.Text);
                doctors.Nationality = Doctor_Nationality_Manage_TextBox.Text;
                doctors.Address = Doctor_Address_Manage_TextBox.Text;
                doctors.Blood_Group = Doctor_Manage_BloodG_ComboBox.Text;
                doctors.Gender = Doctor_Manage_Gender_ComboBox.Text;
                doctors.Salary = Convert.ToDouble(Doctor_Salary_Manage_TextBox.Text);
                doctors.Experience = Doctor_Experience_Manage_TextBox.Text;

                string Department_Name = Doctor_Department_Manage_ComboBox.Text;
                user.User_ID = Int32.Parse(UserID_TextBox.Text);
                user.Username = Doctor_Usernmae_Manage_TextBox.Text;

                bool Issuccess = newDoctorDataAccess.GetDoctorUpdate(doctors, Department_Name, user);

                if (Issuccess)
                {
                    MessageBox.Show("Successfully Doctor Updated.");
                    UpdateListOfDoctor();
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

        private void Clear_Doctor_Info_Button_Click(object sender, EventArgs e)
        {
            Doctor_ID_Manage_TextBox.Text = "";
            Doctor_Name_Manage_TextBox.Text = "";
            Doctor_Usernmae_Manage_TextBox.Clear();
            Doctor_Password_Manage_TextBox.Clear();
            Doctor_Email_Manage_TextBox.Text = "";
            Doctor_Mobile_Manage_TextBox.Text = "";
            Doctor_Manage_DateTimePicker.Text = "";
            Doctor_Nationality_Manage_TextBox.Text = "";
            Doctor_Address_Manage_TextBox.Text = "";
            Doctor_Manage_BloodG_ComboBox.Text = "";
            Doctor_Manage_Gender_ComboBox.Text = "";
            Doctor_Salary_Manage_TextBox.Text = "";
            Doctor_Experience_Manage_TextBox.Text = "";
            Doctor_Department_Manage_ComboBox.Text = "";
            //Doctor_Manage_PictureBox1.Text = null;
        }

        private void Edit_Doctor_Info_Button_Click(object sender, EventArgs e)
        {

        }

        private void Select_Doctor_Manage_Picture_Button_Click(object sender, EventArgs e)
        {
            /*try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "JPEG|*jpg", ValidateNames = true, Multiselect = false };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Doctor_Manage_PictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

/*        public void ConvertImage()
        {
            if (Doctor_Manage_PictureBox1.Image != null)
            {
                MemoryStream memoryStream = new MemoryStream();

                Doctor_Manage_PictureBox1.Image.Save(memoryStream, Doctor_Manage_PictureBox1.Image.RawFormat);

                byte[] imageArray = new byte[memoryStream.Length];
                memoryStream.Position = 0;
                memoryStream.Read(imageArray, 0, imageArray.Length);
                memoryStream.Close();
            }
        }*/

        private void Doctor_Department_Manage_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Department_Manage_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Manage_Doctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hCMSDataSet1.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hCMSDataSet1.Department);

        }
    }
}
