using System;

// Interface for Medical Records
interface IMedicalRecord
{
    void AddRecord(string diagnosis);
    void ViewRecords();
}

// Abstract Base Class
abstract class Patient
{
    public int patientId;
    protected string name;
    protected int age;

    private string diagnosis;          // sensitive data
    private string medicalHistory;     // sensitive data

    public Patient(int id, string n, int a)
    {
        patientId = id;
        name = n;
        age = a;
        medicalHistory = "";
    }

    public string GetPatientDetails()
    {
        return "Patient ID: " + patientId + ", Name: " + name + ", Age: " + age;
    }

    protected void SetDiagnosis(string d)
    {
        diagnosis = d;
        medicalHistory += d + "; ";
    }

    protected string GetDiagnosis()
    {
        return diagnosis;
    }

    public abstract double CalculateBill();
}

// InPatient Subclass
class InPatient : Patient, IMedicalRecord
{
    private int daysAdmitted;

    public InPatient(int id, string n, int a, int days)
        : base(id, n, a)
    {
        daysAdmitted = days;
    }

    public override double CalculateBill()
    {
        return daysAdmitted * 1000;    // bill based on days
    }

    public void AddRecord(string d)
    {
        SetDiagnosis(d);
        Console.WriteLine("Diagnosis Record Added for InPatient");
    }

    public void ViewRecords()
    {
        Console.WriteLine("Current Diagnosis: " + GetDiagnosis());
    }
}

// OutPatient Subclass
class OutPatient : Patient, IMedicalRecord
{
    private int visitCount;

    public OutPatient(int id, string n, int a, int visits)
        : base(id, n, a)
    {
        visitCount = visits;
    }

    public override double CalculateBill()
    {
        return visitCount * 300;     // bill per visit
    }

    public void AddRecord(string d)
    {
        SetDiagnosis(d);
        Console.WriteLine("Diagnosis Record Added for OutPatient");
    }

    public void ViewRecords()
    {
        Console.WriteLine("Latest Diagnosis: " + GetDiagnosis());
    }
}

// Main System to show Polymorphism
class HospitalSystem
{
    static void ProcessPatient(Patient p)
    {
        Console.WriteLine("\n" + p.GetPatientDetails());
        Console.WriteLine("Bill Amount: " + p.CalculateBill());
    }

    static void Main()
    {
        Patient[] patients = new Patient[2];

        patients[0] = new InPatient(1, "Rohit", 30, 5);
        patients[1] = new OutPatient(2, "Amit", 25, 3);

        Console.WriteLine("Processing Patients Dynamically:");

        foreach (Patient p in patients)
        {
            ProcessPatient(p);     // polymorphic behavior
        }

        Console.WriteLine("\nTesting Interface Behavior:");

        IMedicalRecord m = patients[0] as IMedicalRecord;
        m.AddRecord("Fever");
        m.ViewRecords();

        IMedicalRecord m2 = patients[1] as IMedicalRecord;
        m2.AddRecord("Cold");
        m2.ViewRecords();
    }
}
