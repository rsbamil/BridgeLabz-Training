using System;
using Microsoft.Data.SqlClient;
using DBConnect.Interfaces;
using DBConnect.Models;

namespace DBConnect.Services
{
    public class PatientService : IPatientService
    {
        public void RegisterPatient(Patient p)
        {
            using (SqlConnection con = DbConnectionUtil.GetConnection())
            {
                string query = "Insert into Patients(name,dob,phone,email,address,blood_group)" +
                "Values(@name,@dob,@phone,@email,@address,@blood)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", p.Name);
                cmd.Parameters.AddWithValue("@dob", p.DOB);
                cmd.Parameters.AddWithValue("@phone", p.Phone);
                cmd.Parameters.AddWithValue("@email", p.Email);
                cmd.Parameters.AddWithValue("@address", p.Address);
                cmd.Parameters.AddWithValue("@blood", p.BloodGroup);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Patient Registered Successfully!");
            }
        }

        public void UpdatePatient(int id, string address)
        {
            using (SqlConnection con = DbConnectionUtil.GetConnection())
            {
                string query = "UPDATE Patients SET address=@address WHERE patient_id=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Patient Updated Successfully!");
            }
        }

        public void SearchPatient(string name)
        {

            using (SqlConnection con = DbConnectionUtil.GetConnection())
            {
                string query = "SELECT * FROM Patients WHERE name LIKE @name";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", "%" + name + "%");

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["patient_id"]}, Name: {reader["name"]}, Phone: {reader["phone"]}");
                }
            }
        }
    }
}
