using Hospital_Management_System.Users;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System.User_Data_Access
{
    internal class AppoinmentDataAccess : DataAccess
    {
        public List<Appointment> GetAppointmentInfo()
        {
            try
            {
                string sql = "select Appointment.*, Doctor.d_name, Doctor.email, Doctor.mobile from Appointment join Doctor on Appointment.fk_d_id = Doctor.d_id";

                SqlDataReader sqlDataReader = this.GetData(sql);

                List<Appointment> appointments = new List<Appointment>();

                while (sqlDataReader.Read())
                {
                    Appointment appointmen = new Appointment();

                    appointmen.Appointment_ID = (int)sqlDataReader["appointment_id"];
                    appointmen.Patient_ID = (int)sqlDataReader["fk_p_id"];
                    appointmen.Doctor_ID = (int)sqlDataReader["fk_d_id"];
                    appointmen.Name = sqlDataReader["d_name"].ToString(); 
                    appointmen.Email = sqlDataReader["email"].ToString();
                    appointmen.Mobile = sqlDataReader["mobile"].ToString();
                    appointmen.Accepted_Date = (DateTime)sqlDataReader["accepted_date"];

                    appointments.Add(appointmen);
                }

                return appointments;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /*public bool AddAppoinment(Appointment appointmentID)
        {
            string sql = "insert into Appointment (department_name) values (@department_name)";

            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@departmant_id", departmentID.Department_ID);
            sqlCommand.Parameters.AddWithValue("@department_name", appointmentID.Department_Name);

            int result = sqlCommand.ExecuteNonQuery();

            if (result > 0)
            {
                return true;
            }
            return false;
        }*/
    }
}
