using Hospital_Management_System.Users;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.User_Data_Access
{
    internal class AdminDataAccess : DataAccess
    {
        public Admin GetAdminByUserID(int userId)
        {
            string sql = "select * from Admin where fk_u_id = '" + userId + "'";

            SqlDataReader sqlDataReader = this.GetData(sql);

            while (sqlDataReader.Read())
            {
                Admin admin = new Admin();

                admin.Name = sqlDataReader["name"].ToString();
                admin.User_ID = (int)sqlDataReader["fk_u_id"];
                admin.Email = sqlDataReader["email"].ToString();
                admin.Admin_ID = (int)sqlDataReader["admin_id"];

                return admin;
            }
            return null;
        }
    }
}
