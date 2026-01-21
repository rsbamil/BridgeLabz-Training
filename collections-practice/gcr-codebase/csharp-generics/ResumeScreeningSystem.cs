using System;
using System.Collections.Generic;
abstract class JobRole
{
    public abstract string RoleName();
}
class SoftwareEngineer : JobRole
{
    public override string RoleName()
    {
        return "Software Engineer";
    }
}
class DataScientist : JobRole
{
    public override string RoleName()
    {
        return "Data Scientist";
    }
}
class Resume<T> where T : JobRole
{
    public string CandidateName;
    List<T> roles = new List<T>();
    public Resume(string candidateName)
    {
        CandidateName = candidateName;
    }
    public void AddRole(T role)
    {
        roles.Add(role);
    }
    public void DisplayResume()
    {
        Console.WriteLine("Candidate : " + CandidateName);
        foreach (var role in roles)
        {
            Console.WriteLine("Applied Role: " + role.RoleName());
        }
    }
}
class ResumeScreening
{
    public static void ScreenResume<T>(Resume<T> resume) where T : JobRole
    {
        System.Console.Write("Screening Resume for ");
        resume.DisplayResume();
    }
}
class ResumeScreeningSystem
{
    static void Main()
    {
        Resume<SoftwareEngineer> seResume = new Resume<SoftwareEngineer>("RK");
        seResume.AddRole(new SoftwareEngineer());
        Resume<DataScientist> dsResume = new Resume<DataScientist>("Anita");
        dsResume.AddRole(new DataScientist());
        ResumeScreening.ScreenResume(seResume);
        ResumeScreening.ScreenResume(dsResume);
    }
}