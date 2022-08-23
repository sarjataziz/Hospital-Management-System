using Hospital_Management_System.Users;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Hospital_Management_System.User_Data_Access
{
    internal class TestDataAccess : DataAccess
    {
        public List<Test> GetTestsDetails()
        {
            try
            {
                string sql = "select Test.*, Patient.p_name from Test join Patient on Test.fk_p_id = Patient.p_id";

                SqlDataReader sqlDataReader = this.GetData(sql);

                List<Test> tests = new List<Test>();

                while (sqlDataReader.Read())
                {
                    Test test = new Test();

                    test.Test_ID = (int)sqlDataReader["test_id"];
                    test.Test_Name = sqlDataReader["test_name"].ToString();
                    test.Date = (DateTime)sqlDataReader["Date"];
                    test.Recives_Date = (DateTime)sqlDataReader["recives_Date"];
                    test.Fee = (int)sqlDataReader["fee"];
                    test.Patient_ID = (int)sqlDataReader["fk_p_id"];
                    test.Name = sqlDataReader["p_name"].ToString();

                    tests.Add(test);
                }
                return tests;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }            
        }

        public bool AddTestsDetails(Test testID)
        {
            try
            {
                string sql = "insert into Test (test_name,Date,recives_Date,fee,fk_p_id) values (@test_name,@Date,@recives_Date,@fee,@fk_p_id)";

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@test_name", testID.Test_Name);
                sqlCommand.Parameters.AddWithValue("@Date", testID.Date);
                sqlCommand.Parameters.AddWithValue("@recives_Date", testID.Recives_Date);
                sqlCommand.Parameters.AddWithValue("@fee", testID.Fee);
                sqlCommand.Parameters.AddWithValue("@fk_p_id", testID.Patient_ID);

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

        public bool DeleteTestsDetails(int test_ID)
        {
            try
            {
                string sql = "delete from Test where test_id = " + test_ID;

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

        public Test GetTestsByID(int test_ID)
        {
            try
            {
                string sql = "select * from Test where test_id = " + test_ID;

                SqlDataReader sqlDataReader = this.GetData(sql);

                while (sqlDataReader.Read())
                {
                    Test test = new Test();

                    test.Test_ID = (int)sqlDataReader["test_id"];
                    test.Test_Name = sqlDataReader["test_name"].ToString();
                    test.Date = (DateTime)sqlDataReader["Date"];
                    test.Recives_Date = (DateTime)sqlDataReader["recives_Date"];
                    test.Fee = (int)sqlDataReader["fee"];
                    test.Patient_ID = (int)sqlDataReader["fk_p_id"];

                    return test;
                }

                return null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public List<Test> GetTestsInSearch(string search)
        {
            try
            {
                List<Test> tests = new List<Test>();

                string sql = "select * from Test where test_id like '" + search + "%' or test_name like '" + search + "%'";

                SqlDataReader sqlDataReader = this.GetData(sql);

                while (sqlDataReader.Read())
                {
                    Test test = new Test();

                    test.Test_ID = (int)sqlDataReader["test_id"];
                    test.Test_Name = sqlDataReader["test_name"].ToString();
                    test.Date = (DateTime)sqlDataReader["Date"];
                    test.Recives_Date = (DateTime)sqlDataReader["recives_Date"];
                    test.Fee = (int)sqlDataReader["fee"];
                    test.Patient_ID = (int)sqlDataReader["fk_p_id"];

                    tests.Add(test);
                }

                return tests;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }            
        }

        public bool GetTestsUpdate(Test testID)
        {
            try
            {
                string sql = "update Test set test_name = @test_name, Date = @Date, recives_Date = @recives_Date, fee = @fee, fk_p_id = @fk_p_id where test_id = @test_id";

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@test_name", testID.Test_Name);
                sqlCommand.Parameters.AddWithValue("@Date", testID.Date);
                sqlCommand.Parameters.AddWithValue("@recives_Date", testID.Recives_Date);
                sqlCommand.Parameters.AddWithValue("@fee", testID.Fee);
                sqlCommand.Parameters.AddWithValue("@fk_p_id", testID.Patient_ID);
                sqlCommand.Parameters.AddWithValue("@test_id", testID.Test_ID);

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
