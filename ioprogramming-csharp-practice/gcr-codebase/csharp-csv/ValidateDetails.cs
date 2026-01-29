using System;
using System.IO;
using System.Text.RegularExpressions;

class ValidateDetails
{
    static void Main()
    {
        string filePath = "validate.csv";

        // Regex patterns
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string phonePattern = @"^\d{10}$";

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("Invalid Records:\n");

            for (int i = 1; i < lines.Length; i++) // skip header
            {
                string[] data = lines[i].Split(',');

                string email = data[2];
                string phone = data[3];

                bool isEmailValid = Regex.IsMatch(email, emailPattern);
                bool isPhoneValid = Regex.IsMatch(phone, phonePattern);

                if (!isEmailValid || !isPhoneValid)
                {
                    Console.WriteLine("Row " + i + 1 + " : " + lines[i]);

                    if (!isEmailValid)
                        Console.WriteLine("Invalid Email");

                    if (!isPhoneValid)
                        Console.WriteLine("Invalid Phone Number");

                    Console.WriteLine();
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error while validating CSV file.");
        }
    }
}
