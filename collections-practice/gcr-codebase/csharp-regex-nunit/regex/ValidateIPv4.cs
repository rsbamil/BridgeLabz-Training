using System;
using System.Text.RegularExpressions;
class ValidateIPv4
{
    static void Main()
    {
        string ip = "192.168.1.1";
        bool valid = Regex.IsMatch(ip, @"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)$");

        Console.WriteLine(valid ? "Valid IP" : "Invalid IP");

    }
}