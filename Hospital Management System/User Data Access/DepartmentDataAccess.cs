using Hospital_Management_System.Users;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Hospital_Management_System.User_Data_Access
{
    internal class DepartmentDataAccess : DataAccess
    {
        public List<Department> GetDepartmentsDetails()
        {
            try
            {
                string sql = "select * from Department";

                SqlDataReader sqlDataReader = this.GetData(sql);

                List<Department> departments = new List<Department>();

                while (sqlDataReader.Read())
                {
                    Department department = new Department();

                    department.Department_ID = (int)sqlDataReader["department_id"];
                    department.Department_Name = sqlDataReader["department_name"].ToString();

                    departments.Add(department);
                }
                return departments;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }            
        }

        public bool AddDepartmentDetails(Department departmentID)
        {
            try
            {
                string sql = "insert into Department (department_name) values (@department_name)";

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@department_name", departmentID.Department_Name);

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

        public bool DeleteDepartmentDetails(int departmentId)
        {
            try
            {
                string sql = "delete from Department where department_id = " + departmentId;

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

        public Department GetDepartmentByID(int departmentID)
        {
            try
            {
                string sql = "select * from Department where department_id = " + departmentID;

                SqlDataReader sqlDataReader = this.GetData(sql);

                while (sqlDataReader.Read())
                {
                    Department department = new Department();

                    department.Department_ID = (int)sqlDataReader["department_id"];
                    department.Department_Name = sqlDataReader["department_name"].ToString();

                    return department;
                }
                return null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }          
        }

        public List<Department> GetDepartmentInSearch(string search)
        {
            try
            {
                List<Department> departments = new List<Department>();

                string sql = "select * from Department where department_id like '" + search + "%' or department_name like '" + search + "%'";

                SqlDataReader sqlDataReader = this.GetData(sql);

                while (sqlDataReader.Read())
                {
                    Department department = new Department();

                    department.Department_ID = (int)sqlDataReader["department_id"];
                    department.Department_Name = sqlDataReader["department_name"].ToString();
                    departments.Add(department);
                }

                return departments;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }           
        }

        public bool GetDepartmentUpdate(Department departmentID)
        {
            try
            {
                string sql = "update Department set department_name = @department_name where department_id = @department_id";

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@department_id", departmentID.Department_ID);
                sqlCommand.Parameters.AddWithValue("@department_name", departmentID.Department_Name);

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
