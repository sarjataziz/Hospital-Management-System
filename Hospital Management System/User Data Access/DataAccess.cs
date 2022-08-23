using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Hospital_Management_System.User_Data_Access
{
    public class DataAccess:IDisposable
    {
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;

        public DataAccess()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HCMS"].ConnectionString);
            this.sqlConnection.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            try
            {
                this.sqlCommand = new SqlCommand(sql, sqlConnection);
                return this.sqlCommand.ExecuteReader();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public int ExecuteQuery(string sql)
        {
            try
            {
                this.sqlCommand = new SqlCommand(sql, sqlConnection);
                return this.sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public void Dispose()
        {
            this.sqlConnection.Close();
        }
    }
}
