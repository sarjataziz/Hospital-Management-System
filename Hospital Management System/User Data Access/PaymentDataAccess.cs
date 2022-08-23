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
    internal class PaymentDataAccess : DataAccess
    {
        public List<Bill_Payment> GetAllPaymentDetails()
        {
            try
            {
                string sql = "select * from Bill_Payment";

                SqlDataReader sqlDataReader = this.GetData(sql);

                List<Bill_Payment> bill_Payments = new List<Bill_Payment>();

                while (sqlDataReader.Read())
                {
                    Bill_Payment bill_Payment = new Bill_Payment();

                    bill_Payment.Payment_ID = (int)sqlDataReader["payment_id"];
                    bill_Payment.Total_Bill = (int)sqlDataReader["total_bill"];
                    bill_Payment.Payment_Method = sqlDataReader["payment_method"].ToString();
                    bill_Payment.Payment_Date = (DateTime)sqlDataReader["payment_date"];
                    bill_Payment.Patient_ID = (int)sqlDataReader["fk_p_id"];

                    bill_Payments.Add(bill_Payment);
                }

                return bill_Payments;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public List<Bill_Payment> GetPaymentInSearch(string search)
        {
            try
            {
                List<Bill_Payment> bill_Payments = new List<Bill_Payment>();

                string sql = "select * from Bill_Payment where payment_id like '" + search + "%' or payment_method like '" + search + "%' or fk_p_id like '" + search + "%'";

                SqlDataReader sqlDataReader = this.GetData(sql);

                while (sqlDataReader.Read())
                {
                    Bill_Payment bill_Payment = new Bill_Payment();

                    bill_Payment.Payment_ID = (int)sqlDataReader["payment_id"];
                    bill_Payment.Total_Bill = (int)sqlDataReader["total_bill"];
                    bill_Payment.Payment_Method = sqlDataReader["payment_method"].ToString();
                    bill_Payment.Payment_Date = (DateTime)sqlDataReader["payment_date"];
                    bill_Payment.Patient_ID = (int)sqlDataReader["fk_p_id"];

                    bill_Payments.Add(bill_Payment);
                }

                return bill_Payments;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }           
        }
    }
}
