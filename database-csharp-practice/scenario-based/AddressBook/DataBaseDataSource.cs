using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace AddressBook
{
    public class DatabaseDataSource : IDataSource
    {
        private readonly string connectionString;

        public DatabaseDataSource(string connString)
        {
            connectionString = connString;
        }

        public void Save(List<AddressBook> contacts)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (var c in contacts)
                {
                    string query = @"INSERT INTO AddressBookContacts 
                    (FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email)
                    VALUES 
                    (@FirstName, @LastName, @Address, @City, @State, @Zip, @PhoneNumber, @Email)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", c.firstName);
                        cmd.Parameters.AddWithValue("@LastName", c.lastName);
                        cmd.Parameters.AddWithValue("@Address", c.address);
                        cmd.Parameters.AddWithValue("@City", c.city);
                        cmd.Parameters.AddWithValue("@State", c.state);
                        cmd.Parameters.AddWithValue("@Zip", c.zip);
                        cmd.Parameters.AddWithValue("@PhoneNumber", c.phoneNumber);
                        cmd.Parameters.AddWithValue("@Email", c.email);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            Console.WriteLine("Address Book saved to Database successfully.");
        }

        public List<AddressBook> Load()
        {
            List<AddressBook> contacts = new List<AddressBook>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM AddressBookContacts";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AddressBook contact = new AddressBook
                        {
                            firstName = reader["FirstName"].ToString(),
                            lastName = reader["LastName"].ToString(),
                            address = reader["Address"].ToString(),
                            city = reader["City"].ToString(),
                            state = reader["State"].ToString(),
                            zip = reader["Zip"].ToString(),
                            phoneNumber = reader["PhoneNumber"].ToString(),
                            email = reader["Email"].ToString()
                        };

                        contacts.Add(contact);
                    }
                }
            }

            Console.WriteLine("Address Book loaded from Database successfully.");
            return contacts;
        }
    }
}
