using System;
using Microsoft.Data.SqlClient;
using DBConnect.Interfaces;

namespace DBConnect.Services
{
    public class AppointmentService : IAppointmentService
    {
        public void BookAppointment(int patientId, int doctorId, string date, string time)
        {
            using (SqlConnection con = DbConnectionUtil.GetConnection())
            {
                string query = @"INSERT INTO Appointments(patient_id, doctor_id, appointment_date, appointment_time) 
                                 VALUES (@p,@d,@date,@time)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@p", patientId);
                cmd.Parameters.AddWithValue("@d", doctorId);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@time", time);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Appointment Booked!");
            }
        }

        public void CancelAppointment(int appointmentId)
        {
            using (SqlConnection con = DbConnectionUtil.GetConnection())
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Appointments SET status='CANCELLED' WHERE appointment_id=@id",
                        con, tx);

                    cmd.Parameters.AddWithValue("@id", appointmentId);
                    cmd.ExecuteNonQuery();

                    SqlCommand log = new SqlCommand(
                        "INSERT INTO Audit_Log(table_name, operation) VALUES('Appointments','CANCELLED')",
                        con, tx);

                    log.ExecuteNonQuery();
                    tx.Commit();

                    Console.WriteLine("Appointment Cancelled!");
                }
                catch
                {
                    tx.Rollback();
                    Console.WriteLine("Error Occurred!");
                }
            }
        }

        public void ViewDailySchedule(string date)
        {
            using (SqlConnection con = DbConnectionUtil.GetConnection())
            {
                string query = @"SELECT p.name, d.name AS doctor, a.appointment_time
                                 FROM Appointments a
                                 JOIN Patients p ON a.patient_id=p.patient_id
                                 JOIN Doctors d ON a.doctor_id=d.doctor_id
                                 WHERE a.appointment_date=@date
                                 ORDER BY a.appointment_time";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@date", date);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"Patient: {reader["name"]}, Doctor: {reader["doctor"]}, Time: {reader["appointment_time"]}");
                }
            }
        }
    }
}
