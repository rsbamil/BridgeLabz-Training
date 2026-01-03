using System;
class Patient
{
    static string hospitalName = "XYZ Hospital";
    static int totalPatients = 0;
    string name;
    int age;
    string ailment;
    readonly int patientID;
    public Patient(string name, int age, string ailment, int patientID)
    {
        this.name = name;
        this.age = age;
        this.ailment = ailment;
        this.patientID = patientID;
        totalPatients++;
    }
    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients: " + totalPatients);
    }
    public void DisplayPatientInfo()
    {
        Console.WriteLine("Patient ID: " + patientID + ", Name: " + name + ", Age: " + age + ", Ailment: " + ailment + ", Hospital: " + hospitalName);
    }
}
class HospitalManagementSystem
{
    static void Main()
    {
        Patient p1 = new Patient("RK", 30, "Flu", 101);
        Patient p2 = new Patient("Dev", 45, "Fracture", 102);
        if (p1 is Patient)
        {
            Console.WriteLine("p1 is an instance of Patient");
            p1.DisplayPatientInfo();
        }
        if (p2 is Patient)
        {
            Console.WriteLine("p2 is an instance of Patient");
            p2.DisplayPatientInfo();
        }
        Patient.GetTotalPatients();
    }
}