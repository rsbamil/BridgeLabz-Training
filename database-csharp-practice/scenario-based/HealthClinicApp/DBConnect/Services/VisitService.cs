using System;
using Microsoft.Data.SqlClient;
using DBConnect.Interfaces;
using DBConnect.Models;

namespace DBConnect.Services
{
    public class VisitService : IVisitService
    {
        public void RecordVisit(int appointmentId, string diagnosis, string notes)
        {
            using (SqlConnection con = DbConnectionUtil.GetConnection())
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Visits(appointment_id, diagnosis, notes) VALUES(@a,@d,@n)",
                        con, tx);

                    cmd.Parameters.AddWithValue("@a", appointmentId);
                    cmd.Parameters.AddWithValue("@d", diagnosis);
                    cmd.Parameters.AddWithValue("@n", notes);
                    cmd.ExecuteNonQuery();

                    SqlCommand upd = new SqlCommand(
                        "UPDATE Appointments SET status='COMPLETED' WHERE appointment_id=@a",
                        con, tx);

                    upd.Parameters.AddWithValue("@a", appointmentId);
                    upd.ExecuteNonQuery();

                    tx.Commit();
                    Console.WriteLine("Visit Recorded!");
                }
                catch
                {
                    tx.Rollback();
                    Console.WriteLine("Transaction Failed!");
                }
            }
        }
    }
}