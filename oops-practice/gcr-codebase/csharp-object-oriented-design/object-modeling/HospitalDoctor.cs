using System;

public class Patient
{
    public string Name;

    public Patient(string name)
    {
        Name = name;
    }
}

public class Doctor
{
    public string Name;
    public Patient[] Patients = new Patient[10];
    int count = 0;

    public Doctor(string name)
    {
        Name = name;
    }

    // Association + Communication
    public void Consult(Patient p)
    {
        Patients[count++] = p;
        Console.WriteLine("Doctor " + Name + " is consulting Patient " + p.Name);
    }

    public void ShowPatients()
    {
        Console.WriteLine("\nDoctor " + Name + " has consulted:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("   " + Patients[i].Name);
        }
    }
}

public class Hospital
{
    public string HospitalName;
    public Doctor[] Doctors;
    public Patient[] Patients;
    int dCount = 0, pCount = 0;

    public Hospital(string name, int dSize, int pSize)
    {
        HospitalName = name;
        Doctors = new Doctor[dSize];
        Patients = new Patient[pSize];
    }

    // Aggregation: hospital has doctors & patients
    public void AddDoctor(Doctor d)
    {
        Doctors[dCount++] = d;
    }

    public void AddPatient(Patient p)
    {
        Patients[pCount++] = p;
    }
}

class HospitalDoctor
{
    static void Main()
    {
        Hospital h = new Hospital("City Hospital", 5, 5);

        Doctor d1 = new Doctor("Dr. Rohit");
        Doctor d2 = new Doctor("Dr. Aman");

        Patient p1 = new Patient("Neha");
        Patient p2 = new Patient("Rahul");

        h.AddDoctor(d1);
        h.AddDoctor(d2);
        h.AddPatient(p1);
        h.AddPatient(p2);

        // Association + communication
        d1.Consult(p1);
        d1.Consult(p2);
        d2.Consult(p2);

        d1.ShowPatients();
        d2.ShowPatients();
    }
}
