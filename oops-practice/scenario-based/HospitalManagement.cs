using System;
interface IPayable
{
    double CalculateBill();
    double PayBill();
    string GetStatus();
}

class Bill : IPayable
{
    private double amount { get; set; }
    private string status { get; set; }

    public Bill(double amount)
    {
        this.amount = amount;
        this.status = "Unpaid";
    }
    public double CalculateBill()
    {
        return this.amount;
    }
    public string GetStatus()
    {
        return this.status;
    }
    public double PayBill()
    {
        Console.WriteLine("Bill is Paid");
        this.status = "Paid";
        return this.amount;
    }
}

class Person
{
    private string name { get; set; }
    private int age { get; set; }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Name: " + this.name);
        Console.WriteLine("Age: " + this.age);
    }
}
class Doctor : Person
{
    private string specialization { get; set; }
    private Patient[] patients { get; set; }

    public Doctor(string name, int age, string specialization) : base(name, age)
    {
        patients = new Patient[10];
        this.specialization = specialization;
    }

    public void AssignPatients(Patient patient)
    {
        for (int i = 0; i < patients.Length; i++)
            if (patients[i] == null)
            {
                this.patients[i] = patient;
                return;
            }
        Console.WriteLine("Doctor is already assigned to 10 patients");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Doctor Details:");
        Console.WriteLine("----------------");
        base.DisplayInfo();
        Console.WriteLine("Specialization: " + this.specialization + "\n\n");
    }

}
class Patient : Person
{
    private Doctor doctor { get; set; }
    private string disease { get; set; }

    private IPayable bill { get; set; }

    private bool inpatient { get; set; }

    public Patient(string name, int age, string disease) : base(name, age)
    {
        this.disease = disease;
        this.bill = null;
        this.inpatient = false;
        this.doctor = null;
    }
    public void AssignDoctor(Doctor doctor)
    {
        this.doctor = doctor;
        this.inpatient = true;
    }
    public void RemoveDoctor()
    {
        this.doctor = null;
        this.inpatient = false;
    }

    public void AssignBill(IPayable bill)
    {
        this.bill = bill;
    }
    public void PayBill()
    {
        Console.WriteLine("\n\n");
        Console.WriteLine("Payment Details:");
        Console.WriteLine("----------------");
        Console.WriteLine("Amount: " + this.bill.CalculateBill());
        Console.WriteLine("Status: " + this.bill.GetStatus());
        Console.Write("Pay Bill? (Y/N) ");
        char ch = Console.ReadLine()[0];
        if (ch == 'y' || ch == 'Y')
            this.bill.PayBill();
        else
            Console.WriteLine("Bill not paid");
    }
    public override void DisplayInfo()
    {
        Console.WriteLine("Patient Details:");
        Console.WriteLine("----------------");
        base.DisplayInfo();
        Console.WriteLine("disease: " + this.disease);
        Console.WriteLine("Bill: " + this.bill.CalculateBill());
    }

}

class HospitalManagement
{
    public static void Main()
    {
        Doctor doctor = new Doctor("Dr. Sheikh", 35, "Cardiology");
        doctor.DisplayInfo();

        Patient patient = new Patient("Iqbal Qasim", 25, "Heart Attack");

        doctor.AssignPatients(patient);

        patient.AssignDoctor(doctor);
        IPayable bill = new Bill(100);
        patient.AssignBill(bill);
        patient.DisplayInfo();
        patient.RemoveDoctor();

        patient.PayBill();


    }
}