using System;
using Microsoft.Data.SqlClient;
using DBConnect.Interfaces;

namespace DBConnect.Services
{
    public class BillingService : IBillingService
    {
        public void GenerateBill(int visitId, decimal amount)
        {
            using (SqlConnection con = DbConnectionUtil.GetConnection())
            {
                string query = "INSERT INTO Bills(visit_id, total_amount) VALUES(@v,@amt)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@v", visitId);
                cmd.Parameters.AddWithValue("@amt", amount);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Bill Generated!");
            }
        }

        public void RecordPayment(int billId)
        {
            using (SqlConnection con = DbConnectionUtil.GetConnection())
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();

                try
                {
                    SqlCommand upd = new SqlCommand(
                        "UPDATE Bills SET payment_status='PAID', payment_date=GETDATE() WHERE bill_id=@b",
                        con, tx);

                    upd.Parameters.AddWithValue("@b", billId);
                    upd.ExecuteNonQuery();

                    SqlCommand ins = new SqlCommand(
                        "INSERT INTO Payment_Transactions(bill_id, payment_mode) VALUES(@b,'UPI')",
                        con, tx);

                    ins.Parameters.AddWithValue("@b", billId);
                    ins.ExecuteNonQuery();

                    tx.Commit();
                    Console.WriteLine("Payment Recorded!");
                }
                catch
                {
                    tx.Rollback();
                    Console.WriteLine("Payment Failed!");
                }
            }
        }
    }
}
