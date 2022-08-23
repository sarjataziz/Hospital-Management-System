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
    internal class PrescriptionDataAccess : DataAccess
    {
        public List<Prescription> GetAllPrescriptionDetails()
        {
            try
            {
                string sql = "select Prescription.*, Patient.* from Prescription join Patient on Prescription.fk_p_id = Patient.p_id";

                SqlDataReader sqlDataReader = this.GetData(sql);

                List<Prescription> prescriptions = new List<Prescription>();

                while (sqlDataReader.Read())
                {
                    Prescription prescriptionData = new Prescription();

                    prescriptionData.Patient_ID = (int)sqlDataReader["p_id"];
                    prescriptionData.Doctor_ID = (int)sqlDataReader["fk_d_id"];
                    prescriptionData.Name = sqlDataReader["p_name"].ToString();
                    prescriptionData.Prescription_ID = (int)sqlDataReader["pre_id"];
                    prescriptionData.Prescription_Details = sqlDataReader["pre_details"].ToString();
                    prescriptionData.Sickness = sqlDataReader["sickness"].ToString();
                    prescriptionData.Blood_Group = sqlDataReader["blood_group"].ToString();
                    prescriptionData.Gender = sqlDataReader["gender"].ToString();

                    prescriptions.Add(prescriptionData);
                }
                return prescriptions;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool AddPrescriptionDetails(Prescription prescription)
        {
            try
            {
                string sql = "insert into Prescription (fk_d_id, fk_p_id, pre_details, sickness) " +
                " values (@fk_d_id, @fk_p_id, @pre_details, @sickness)";

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@fk_d_id", prescription.Doctor_ID);;
                sqlCommand.Parameters.AddWithValue("@fk_p_id", prescription.Patient_ID);
                sqlCommand.Parameters.AddWithValue("@pre_details", prescription.Prescription_Details);
                sqlCommand.Parameters.AddWithValue("@sickness", prescription.Sickness);

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

        public bool DeletePrescriptionDetails(int prescriptionID)
        {
            try
            {
                string sql = "delete from Prescription where pre_id = " + prescriptionID;

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

        public Prescription GetPrescriptionsByID(int prescriptionID)
        {
            try
            {
                string sql = "select * from Prescription where pre_id = " + prescriptionID;

                SqlDataReader sqlDataReader = this.GetData(sql);

                while (sqlDataReader.Read())
                {
                    Prescription prescription = new Prescription();

                    prescription.Patient_ID = (int)sqlDataReader["fk_p_id"];
                    prescription.Prescription_ID = (int)sqlDataReader["pre_id"];
                    prescription.Prescription_Details = sqlDataReader["pre_details"].ToString();
                    prescription.Sickness = sqlDataReader["sickness"].ToString();
                    prescription.Doctor_ID = (int)sqlDataReader["fk_d_id"];

                    return prescription;
                }

                return null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<Prescription> GetPrescriptionInSearch(string search)
        {
            try
            {
                List<Prescription> prescriptions = new List<Prescription>();

                string sql = "select * from Prescription where pre_id like '" + search + "%'";

                SqlDataReader sqlDataReader = this.GetData(sql);

                while (sqlDataReader.Read())
                {
                    Prescription prescription = new Prescription();

                    prescription.Patient_ID = (int)sqlDataReader["fk_p_id"];
                    //prescription.Name = sqlDataReader["p_name"].ToString();
                    //prescription.Blood_Group = sqlDataReader["blood_group"].ToString();
                    //.Gender = sqlDataReader["gender"].ToString();
                    prescription.Doctor_ID = (int)sqlDataReader["fk_d_id"];
                    prescription.Sickness = sqlDataReader["sickness"].ToString();
                    prescription.Prescription_Details = sqlDataReader["pre_details"].ToString();
                    prescriptions.Add(prescription);
                }

                return prescriptions;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool GetPrescriptionUpdate(Prescription prescription)
        {
            try
            {
                string sql = "update Prescription set fk_d_id = @fk_d_id, fk_p_id = @fk_p_id, pre_details = @pre_details, sickness = @sickness  where pre_id = @pre_id";

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@fk_d_id", prescription.Doctor_ID); ;
                sqlCommand.Parameters.AddWithValue("@fk_p_id", prescription.Patient_ID);
                sqlCommand.Parameters.AddWithValue("@pre_details", prescription.Prescription_Details);
                sqlCommand.Parameters.AddWithValue("@sickness", prescription.Sickness);
                sqlCommand.Parameters.AddWithValue("@pre_id", prescription.Prescription_ID);

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
