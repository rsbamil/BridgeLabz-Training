using System;
using Microsoft.Data.SqlClient;
using DBConnect.Interfaces;
using DBConnect.Models;

namespace DBConnect.Services
{
    public class DoctorService : IDoctorService
    {
        public void AddDoctor(Doctor d)
        {
            using (SqlConnection con = DbConnectionUtil.GetConnection())
            {
                string query = "INSERT INTO Doctors(name, specialty_id, phone, consultation_fee) " +
                               "VALUES (@name,@spec,@phone,@fee)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", d.Name);
                cmd.Parameters.AddWithValue("@spec", d.SpecialtyId);
                cmd.Parameters.AddWithValue("@phone", d.Phone);
                cmd.Parameters.AddWithValue("@fee", d.ConsultationFee);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Doctor Added Successfully!");
            }
        }

        public void DeactivateDoctor(int doctorId)
        {
            using (SqlConnection con = DbConnectionUtil.GetConnection())
            {
                string query = "UPDATE Doctors SET is_active=0 WHERE doctor_id=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", doctorId);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Doctor Deactivated!");
            }
        }

        public void ViewDoctorsBySpecialty(string specialty)
        {
            using (SqlConnection con = DbConnectionUtil.GetConnection())
            {
                string query = @"SELECT d.name, s.specialty_name 
                                 FROM Doctors d 
                                 JOIN Specialties s 
                                 ON d.specialty_id = s.specialty_id
                                 WHERE s.specialty_name=@spec";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@spec", specialty);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"Doctor: {reader["name"]}, Specialty: {reader["specialty_name"]}");
                }
            }
        }
    }
}
