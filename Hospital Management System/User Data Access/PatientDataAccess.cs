using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Management_System.Users;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Hospital_Management_System.User_Data_Access
{
    internal class PatientDataAccess : DataAccess
    {
        public List<Patient> GetAllPatientsDetails()
        {
            try
            {
                string sql = "select Patient.*, Users.username from Patient join Users on Patient.fk_u_id = Users.u_id";

                SqlDataReader sqlDataReader = this.GetData(sql);

                List<Patient> patients = new List<Patient>();

                while (sqlDataReader.Read())
                {
                    Patient patient = new Patient();

                    patient.Patient_ID = (int)sqlDataReader["p_id"];
                    patient.Name = sqlDataReader["p_name"].ToString();
                    patient.User_ID = (int)sqlDataReader["fk_u_id"];
                    patient.Username = sqlDataReader["username"].ToString();
                    patient.Email = sqlDataReader["email"].ToString();
                    patient.Mobile = sqlDataReader["mobile"].ToString();
                    patient.Date_of_Birth = (DateTime)sqlDataReader["date_of_birth"];
                    patient.Nationality = sqlDataReader["nationality"].ToString();
                    patient.Address = sqlDataReader["address"].ToString();
                    patient.Blood_Group = sqlDataReader["blood_group"].ToString();
                    patient.Gender = sqlDataReader["gender"].ToString();
                    patient.Accepted_Date = (DateTime)sqlDataReader["accepted_date"];;

                    patients.Add(patient);
                }
                return patients;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }          
        }

        public bool AddPatientsDetails(Patient patient, User user)
        {
            User temp = new User();
            UserDataAccess userDataAccess = new UserDataAccess();
            temp = userDataAccess.AddUser(user);

            if (temp == null)
            {
                return false;
            }

            try
            {
                string sql = "insert into Patient (p_name,email,mobile,date_of_birth,nationality,address,blood_group,gender,fk_u_id,accepted_date) " +
                " values (@p_name,@email,@mobile,@date_of_birth,@nationality,@address,@blood_group,@gender,@fk_u_id,@accepted_date)";

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@p_name", patient.Name);
                sqlCommand.Parameters.AddWithValue("@fk_u_id", temp.User_ID);
                sqlCommand.Parameters.AddWithValue("@email", patient.Email);
                sqlCommand.Parameters.AddWithValue("@mobile", patient.Mobile);
                sqlCommand.Parameters.AddWithValue("@date_of_birth", patient.Date_of_Birth);
                sqlCommand.Parameters.AddWithValue("@nationality", patient.Nationality);
                sqlCommand.Parameters.AddWithValue("@address", patient.Address);
                sqlCommand.Parameters.AddWithValue("@blood_group", patient.Blood_Group);
                sqlCommand.Parameters.AddWithValue("@gender", patient.Gender);
                sqlCommand.Parameters.AddWithValue("@accepted_date", patient.Accepted_Date);

                int result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }           
        }

        public bool DeletePatientsDetails(int patientID)
        {
            try
            {
                string sql = "delete from Patient where p_id = " + patientID;

                int result = this.ExecuteQuery(sql);

                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }           
        }

        public Patient GetPatientsByID(int patientID)
        {
            try
            {
                string sql = "select * from Patient where p_id = " + patientID;

                SqlDataReader sqlDataReader = this.GetData(sql);

                while (sqlDataReader.Read())
                {
                    Patient patient = new Patient();

                    patient.Patient_ID = (int)sqlDataReader["p_id"];
                    patient.Name = sqlDataReader["p_name"].ToString();
                    patient.User_ID = (int)sqlDataReader["fk_u_id"];
                    patient.Email = sqlDataReader["email"].ToString();
                    patient.Mobile = sqlDataReader["mobile"].ToString();
                    patient.Date_of_Birth = (DateTime)sqlDataReader["date_of_birth"];
                    patient.Nationality = sqlDataReader["nationality"].ToString();
                    patient.Address = sqlDataReader["address"].ToString();
                    patient.Blood_Group = sqlDataReader["blood_group"].ToString();
                    patient.Gender = sqlDataReader["gender"].ToString();
                    patient.Accepted_Date = (DateTime)sqlDataReader["accepted_date"];

                    return patient;
                }

                return null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }           
        }

        public List<Patient> GetPatientsInSearch(string search)
        {
            try
            {
                List<Patient> patients = new List<Patient>();

                string sql = "select * from Patient where p_id like '" + search + "%' or p_name like '" + search + "%' or mobile like '" + search + "%'";

                SqlDataReader sqlDataReader = this.GetData(sql);

                while (sqlDataReader.Read())
                {
                    Patient patient = new Patient();

                    patient.Patient_ID = (int)sqlDataReader["p_id"];
                    patient.Name = sqlDataReader["p_name"].ToString();
                    patient.User_ID = (int)sqlDataReader["fk_u_id"];
                    patient.Email = sqlDataReader["email"].ToString();
                    patient.Mobile = sqlDataReader["mobile"].ToString();
                    patient.Date_of_Birth = (DateTime)sqlDataReader["date_of_birth"];
                    patient.Nationality = sqlDataReader["nationality"].ToString();
                    patient.Address = sqlDataReader["address"].ToString();
                    patient.Blood_Group = sqlDataReader["blood_group"].ToString();
                    patient.Gender = sqlDataReader["gender"].ToString();
                    patient.Accepted_Date = (DateTime)sqlDataReader["accepted_date"];
                    patients.Add(patient);
                }

                return patients;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }           
        }

        public bool GetPatientsUpdate(Patient patient, User user)
        {
            try
            {
                UserDataAccess userDataAccess = new UserDataAccess();
                if (!userDataAccess.UpdateUser(user))
                {
                    return false;
                }

                string sql = "update Patient set email = @email, p_name = @p_name, mobile = @mobile, date_of_birth = @date_of_birth," +
                "nationality = @Nationality, address = @Address, blood_group = @Blood_group, gender = @Gender, accepted_date = @accepted_date " +
                " where p_id = @p_id";

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@p_name", patient.Name);
                sqlCommand.Parameters.AddWithValue("@email", patient.Email);
                sqlCommand.Parameters.AddWithValue("@mobile", patient.Mobile);
                sqlCommand.Parameters.AddWithValue("@date_of_birth", patient.Date_of_Birth);
                sqlCommand.Parameters.AddWithValue("@nationality", patient.Nationality);
                sqlCommand.Parameters.AddWithValue("@address", patient.Address);
                sqlCommand.Parameters.AddWithValue("@blood_group", patient.Blood_Group);
                sqlCommand.Parameters.AddWithValue("@gender", patient.Gender);
                sqlCommand.Parameters.AddWithValue("@accepted_date", patient.Accepted_Date);
                sqlCommand.Parameters.AddWithValue("@p_id", patient.Patient_ID);

                int result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            
        }

        public Patient GetPatientByUserID(int userId)
        {
            string sql = "select * from Patient where fk_u_id = '" + userId + "'";

            SqlDataReader sqlDataReader = this.GetData(sql);

            while (sqlDataReader.Read())
            {
                Patient patient = new Patient();

                patient.Patient_ID = (int)sqlDataReader["p_id"];
                patient.Name = sqlDataReader["p_name"].ToString();
                patient.User_ID = (int)sqlDataReader["fk_u_id"];
                patient.Email = sqlDataReader["email"].ToString();
                patient.Mobile = sqlDataReader["mobile"].ToString();
                patient.Date_of_Birth = (DateTime)sqlDataReader["date_of_birth"];
                patient.Nationality = sqlDataReader["nationality"].ToString();
                patient.Address = sqlDataReader["address"].ToString();
                patient.Blood_Group = sqlDataReader["blood_group"].ToString();
                patient.Gender = sqlDataReader["gender"].ToString();
                patient.Accepted_Date = (DateTime)sqlDataReader["accepted_date"];

                return patient;
            }
            return null;
        }
    }
}
