using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Management_System.Users;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Windows.Documents;

namespace Hospital_Management_System.User_Data_Access
{
    internal class UserDataAccess : DataAccess
    {
        public User LoginValidation(string username, string password)
        {
            try
            {
                string sql = "select * from Users where username = '" + username + "' and password = '" + password + "'";

                SqlDataReader sqlDataReader = this.GetData(sql);

                User user = null;

                while (sqlDataReader.Read())
                {
                    user = new User();
                    user.User_ID = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("u_id"));
                    user.Username = sqlDataReader.GetString(sqlDataReader.GetOrdinal("username"));
                    user.Password = sqlDataReader.GetString(sqlDataReader.GetOrdinal("password"));
                    user.User_Type = sqlDataReader.GetString(sqlDataReader.GetOrdinal("user_type"));

                    break;
                }
                return user;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }                       
                /*while (sqlDataReader.Read())
                {
                    //user = new User();
                    
                    user = sqlDataReader.GetString(sqlDataReader.GetOrdinal("user_type"));
                    //user.User_Type = sqlDataReader.GetString(sqlDataReader.GetOrdinal("user_type"));
                    //Console.WriteLine(userType);

                    break;
                }*/           
        }
        
        public User AddUser(User user)
        {
            try
            {
                string sqlUsername = "select * from Users where username = '" + user.Username + "'";

                SqlDataReader sqlReader = this.GetData(sqlUsername);

                while (sqlReader.Read())
                {
                    MessageBox.Show("Username Already Exist. Plsease Enter Another Username.");
                    return null;
                }

                sqlReader.Close();

                string sql = "insert into Users (username, password, user_type) values (@username, @password, @user_type) ";

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@username", user.Username);
                sqlCommand.Parameters.AddWithValue("@password", user.Password);
                sqlCommand.Parameters.AddWithValue("@user_type", user.User_Type);

                int result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    string sql_user = "select * from Users where username = '" + user.Username + "' and password = '" + user.Password + "'";

                    SqlDataReader sqlDataReader = this.GetData(sql_user);

                    User temp = null;

                    while (sqlDataReader.Read())
                    {
                        temp = new User();

                        temp.User_ID = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("u_id"));
                        temp.Username = sqlDataReader.GetString(sqlDataReader.GetOrdinal("username"));
                        temp.Password = sqlDataReader.GetString(sqlDataReader.GetOrdinal("password"));
                        temp.User_Type = sqlDataReader.GetString(sqlDataReader.GetOrdinal("user_type"));

                        break;
                    }
                    return temp;
                }
                return null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public bool UpdateUser(User user)
        {
            try
            {
                string sqlUsername = "select * from Users where username = '" + user.Username + "'";

                SqlDataReader sqlReader = this.GetData(sqlUsername);

                while (sqlReader.Read())
                {
                    int userId = sqlReader.GetInt32(sqlReader.GetOrdinal("u_id"));
                    if (userId != user.User_ID)
                    {
                        MessageBox.Show("Username Already Exist. Plsease Enter Another Username.");
                        return false;
                    }
                    return true;
                }

                sqlReader.Close();

                string sql = "Update Users set  username = @username where u_id = " + user.User_ID;

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@username", user.Username);

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
           
            /*if (result > 0)
            {
                string sql_user = "select * from Users where username = '" + user.Username + "' and password = '" + user.Password + "'";

                SqlDataReader sqlDataReader = this.GetData(sql_user);

                User temp = null;

                while (sqlDataReader.Read())
                {
                    temp = new User();

                    temp.User_ID = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("u_id"));
                    temp.Username = sqlDataReader.GetString(sqlDataReader.GetOrdinal("username"));
                    temp.Password = sqlDataReader.GetString(sqlDataReader.GetOrdinal("password"));
                    temp.User_Type = sqlDataReader.GetString(sqlDataReader.GetOrdinal("user_type"));

                    break;
                }
                return temp;
            }
            return null;*/
        }

        public bool ChangePassword(User users)
        {
            try
            {
                string sql = "update Users set password = @password where username = @username";

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@username", users.Username);
                sqlCommand.Parameters.AddWithValue("@password", users.Password);
                sqlCommand.Parameters.AddWithValue("@u_id", users.User_ID);

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
        
        public bool Registration(User user)
        {
            try
            {
                string sqlUsername = "select * from Users where username = '" + user.Username + "'";

                SqlDataReader sqlReader = this.GetData(sqlUsername);

                while (sqlReader.Read())
                {
                    MessageBox.Show("Username Already Exist. Plsease Enter Another Username.");
                    return false;
                }

                sqlReader.Close();

                string sql = "insert into Users (username,password,user_type) values (@username,@password,'Patient') ";

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@username", user.Username);
                sqlCommand.Parameters.AddWithValue("@password", user.Password);

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

        public bool ValidCheck(User user)
        {
            try
            {
                string sql = "update into Users (username,password,user_type,user_status) values (@username,@password,'@user_type',@user_status) ";

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@username", user.Username);
                sqlCommand.Parameters.AddWithValue("@password", user.Password);
                sqlCommand.Parameters.AddWithValue("@user_type", user.Password);
                sqlCommand.Parameters.AddWithValue("@user_status", user.User_Status);

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
    }
}
