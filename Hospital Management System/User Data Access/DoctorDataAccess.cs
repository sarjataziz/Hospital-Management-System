using Hospital_Management_System.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System.User_Data_Access
{
    internal class DoctorDataAccess : DataAccess
    {
        public List<Doctor> GetAllDoctorDetails()
        {           
            try
            {
                string sql = "select Doctor.*, Users.username, Department.department_name from Doctor join Users on Doctor.fk_u_id = Users.u_id " +
                "join Department on Doctor.fk_department_id = Department.department_id";

                SqlDataReader sqlDataReader = this.GetData(sql);

                List<Doctor> doctor = new List<Doctor>();

                while (sqlDataReader.Read())
                {
                    Doctor doctors = new Doctor();

                    doctors.Doctor_ID = (int)sqlDataReader["d_id"];
                    doctors.Name = sqlDataReader["d_name"].ToString();
                    doctors.User_ID = (int)sqlDataReader["fk_u_id"];
                    doctors.Username = sqlDataReader["username"].ToString();
                    doctors.Email = sqlDataReader["email"].ToString();
                    doctors.Mobile = sqlDataReader["mobile"].ToString();
                    doctors.Date_of_Birth = (DateTime)sqlDataReader["date_of_birth"];
                    doctors.Nationality = sqlDataReader["nationality"].ToString();
                    doctors.Address = sqlDataReader["address"].ToString();
                    doctors.Blood_Group = sqlDataReader["blood_group"].ToString();
                    doctors.Gender = sqlDataReader["gender"].ToString();
                    doctors.Department_ID = (int)sqlDataReader["fk_department_id"];
                    doctors.Department_Name = sqlDataReader["department_name"].ToString();
                    doctors.Salary = Convert.ToDouble(sqlDataReader["salary"]);
                    doctors.Experience = sqlDataReader["experience"].ToString();

                    doctor.Add(doctors);
                }
                return doctor;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool AddDoctorDetails(Doctor doctor, User user, string DepartmentName)
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
                string sql1 ="select department_id from Department where department_name =  '"+ DepartmentName +"'";

                SqlDataReader sqlDataReader = this.GetData(sql1);

                sqlDataReader.Read();
                int DepartmentId = (int)sqlDataReader["department_id"];

                sqlDataReader.Close();

                string sql2 = "insert into Doctor (fk_department_id,d_name,email,mobile,date_of_birth,nationality,address,blood_group,gender,salary,experience,fk_u_id)" +
                              "values (@fk_department_id,@d_name,@email,@mobile,@date_of_birth,@nationality,@address,@blood_group,@gender,@salary,@experience,@fk_u_id)";

                SqlCommand sqlCommand = new SqlCommand(sql2, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@d_name", doctor.Name);
                sqlCommand.Parameters.AddWithValue("@fk_u_id", temp.User_ID);
                sqlCommand.Parameters.AddWithValue("@email", doctor.Email);
                sqlCommand.Parameters.AddWithValue("@mobile", doctor.Mobile);
                sqlCommand.Parameters.AddWithValue("@date_of_birth", doctor.Date_of_Birth);
                sqlCommand.Parameters.AddWithValue("@nationality", doctor.Nationality);
                sqlCommand.Parameters.AddWithValue("@address", doctor.Address);
                sqlCommand.Parameters.AddWithValue("@blood_group", doctor.Blood_Group);
                sqlCommand.Parameters.AddWithValue("@gender", doctor.Gender);
                sqlCommand.Parameters.AddWithValue("@fk_department_id", DepartmentId);
                sqlCommand.Parameters.AddWithValue("@salary", doctor.Salary);
                sqlCommand.Parameters.AddWithValue("@experience", doctor.Experience);

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

        public bool DeleteDoctorDetails(int doctorID)
        {        
            try
            {
                string sql = "delete from Doctor where d_id = " + doctorID;

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

        public Doctor GetDoctorByID(int doctorID)
        {           
            try
            {
                string sql = "select * from Doctor where d_id = " + doctorID;

                SqlDataReader sqlDataReader = this.GetData(sql);

                while (sqlDataReader.Read())
                {
                    Doctor doctor = new Doctor();

                    doctor.Doctor_ID = (int)sqlDataReader["d_id"];
                    doctor.Name = sqlDataReader["d_name"].ToString();
                    doctor.Email = sqlDataReader["email"].ToString();
                    doctor.Mobile = sqlDataReader["mobile"].ToString();
                    doctor.Date_of_Birth = (DateTime)sqlDataReader["date_of_birth"];
                    doctor.Nationality = sqlDataReader["nationality"].ToString();
                    doctor.Address = sqlDataReader["address"].ToString();
                    doctor.Blood_Group = sqlDataReader["blood_group"].ToString();
                    doctor.Gender = sqlDataReader["gender"].ToString();
                    doctor.Salary = Convert.ToDouble(sqlDataReader["salary"]);
                    doctor.Experience = sqlDataReader["experience"].ToString();

                    return doctor;
                }

                return null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<Doctor> GetDoctorInSearch(string search)
        {          
            try
            {
                List<Doctor> doctor = new List<Doctor>();

                string sql = "select Doctor.*, Users.username, Department.department_name from Doctor join Users on " +
                    "Doctor.fk_u_id = Users.u_id join Department on Doctor.fk_department_id = Department.department_id " +
                    "where d_id like '"+ search  + "%' or d_name like '" + search + "%' or mobile like '"+ search  +"%'";


                SqlDataReader sqlDataReader = this.GetData(sql);

                while (sqlDataReader.Read())
                {
                    Doctor doctors = new Doctor();

                    doctors.Doctor_ID = (int)sqlDataReader["d_id"];
                    doctors.Name = sqlDataReader["d_name"].ToString();
                    doctors.User_ID = (int)sqlDataReader["fk_u_id"];
                    doctors.Username = sqlDataReader["username"].ToString();
                    doctors.Email = sqlDataReader["email"].ToString();
                    doctors.Mobile = sqlDataReader["mobile"].ToString();
                    doctors.Date_of_Birth = (DateTime)sqlDataReader["date_of_birth"];
                    doctors.Nationality = sqlDataReader["nationality"].ToString();
                    doctors.Address = sqlDataReader["address"].ToString();
                    doctors.Blood_Group = sqlDataReader["blood_group"].ToString();
                    doctors.Gender = sqlDataReader["gender"].ToString();
                    doctors.Department_ID = (int)sqlDataReader["fk_department_id"];
                    doctors.Department_Name = sqlDataReader["department_name"].ToString();
                    doctors.Salary = Convert.ToDouble(sqlDataReader["salary"]);
                    doctors.Experience = sqlDataReader["experience"].ToString();
                    doctor.Add(doctors);
                }

                return doctor;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool GetDoctorUpdate(Doctor doctor, string DepartmentName, User user)
        {     
            try
            {
                UserDataAccess userDataAccess = new UserDataAccess();
                if (!userDataAccess.UpdateUser(user))
                {
                    return false;
                }

                string sql1 = "select department_id from Department where department_name =  '" + DepartmentName + "'";

                SqlDataReader sqlDataReader = this.GetData(sql1);

                sqlDataReader.Read();
                int DepartmentId = (int)sqlDataReader["department_id"];

                sqlDataReader.Close();

                string sql = "update Doctor set email = @email, d_name = @d_name, mobile = @mobile, date_of_birth = @date_of_birth," +
                "nationality = @Nationality, address = @Address, blood_group = @Blood_group, gender= @Gender, salary= @Salary, experience = @Experience," +
                " fk_department_id = @fk_department_id where d_id = @d_id";

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@d_name", doctor.Name);
                sqlCommand.Parameters.AddWithValue("@email", doctor.Email);
                sqlCommand.Parameters.AddWithValue("@mobile", doctor.Mobile);
                sqlCommand.Parameters.AddWithValue("@date_of_birth", doctor.Date_of_Birth);
                sqlCommand.Parameters.AddWithValue("@Nationality", doctor.Nationality);
                sqlCommand.Parameters.AddWithValue("@Address", doctor.Address);
                sqlCommand.Parameters.AddWithValue("@Blood_group", doctor.Blood_Group);
                sqlCommand.Parameters.AddWithValue("@Gender", doctor.Gender);
                sqlCommand.Parameters.AddWithValue("@fk_department_id", DepartmentId);
                sqlCommand.Parameters.AddWithValue("@Salary", doctor.Salary);
                sqlCommand.Parameters.AddWithValue("@Experience", doctor.Experience);               
                sqlCommand.Parameters.AddWithValue("@d_id", doctor.Doctor_ID);

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

        public Doctor GetDoctorByUserID(int userId)
        {
            string sql = "select * from Doctor where fk_u_id = '" + userId + "'";

            SqlDataReader sqlDataReader = this.GetData(sql);

            while (sqlDataReader.Read())
            {
                Doctor doctor = new Doctor();

                doctor.Doctor_ID = (int)sqlDataReader["d_id"];
                doctor.Name = sqlDataReader["d_name"].ToString();
                doctor.User_ID = (int)sqlDataReader["fk_u_id"];
                doctor.Email = sqlDataReader["email"].ToString();
                doctor.Mobile = sqlDataReader["mobile"].ToString();
                doctor.Date_of_Birth = (DateTime)sqlDataReader["date_of_birth"];
                doctor.Nationality = sqlDataReader["nationality"].ToString();
                doctor.Address = sqlDataReader["address"].ToString();
                doctor.Blood_Group = sqlDataReader["blood_group"].ToString();
                doctor.Gender = sqlDataReader["gender"].ToString();
                doctor.Salary = Convert.ToDouble(sqlDataReader["salary"]);
                doctor.Experience = sqlDataReader["experience"].ToString();

                return doctor;
            }
            return null;
        }

        /*public List<Doctor> GetAllDoctorInfo()
        {
            try
            {
                string sql = "select Doctor.d_id, Doctor.d_name, Doctor.email, Doctor.mobile, Appointment.accepted_date, Department.department_name " +
                             "from Doctor join Appointment on Doctor.d_id = Appointment.fk_d_id " +
                             "join Department on Doctor.fk_department_id = Department.departmant_id";

                SqlDataReader sqlDataReader = this.GetData(sql);

                List<Doctor> doctors = new List<Doctor>();

                while (sqlDataReader.Read())
                {
                    Doctor doctor = new Doctor();

                    doctor.Doctor_ID = (int)sqlDataReader["d_id"];
                    doctor.Name = sqlDataReader["d_name"].ToString();;
                    doctor.Email = sqlDataReader["email"].ToString();
                    doctor.Mobile = sqlDataReader["mobile"].ToString();
                    doctor.Department_Name = sqlDataReader["department_name"].ToString();
                    doctor.Accepted_Date = (DateTime)sqlDataReader["accepted_date"];

                    doctors.Add(doctor);
                }

                return doctors;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }*/
    }
}
