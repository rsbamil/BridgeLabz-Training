using System;

public class Faculty
{
    public string Name;
    public string Subject;

    public Faculty(string name, string subject)
    {
        Name = name;
        Subject = subject;
    }

    public void Display()
    {
        Console.WriteLine("   Faculty: " + Name + " | Subject: " + Subject);
    }
}

public class Department
{
    public string DeptName;

    public Department(string name)
    {
        DeptName = name;
    }

    public void Display()
    {
        Console.WriteLine("   Department: " + DeptName);
    }
}

public class University
{
    public string UniName;
    public Department[] Departments;
    public Faculty[] Faculties;
    int deptCount = 0;
    int facCount = 0;

    public University(string name, int deptSize, int facSize)
    {
        UniName = name;
        Departments = new Department[deptSize];   // Composition
        Faculties = new Faculty[facSize];         // Aggregation
    }

    // Composition: Department created inside University
    public void AddDepartment(string deptName)
    {
        Departments[deptCount++] = new Department(deptName);
    }

    // Aggregation: Faculty passed from outside
    public void AddFaculty(Faculty f)
    {
        Faculties[facCount++] = f;
    }

    public void ShowUniversity()
    {
        Console.WriteLine("\nUniversity: " + UniName);

        Console.WriteLine(" Departments:");
        for (int i = 0; i < deptCount; i++)
            Departments[i].Display();

        Console.WriteLine(" Faculties:");
        for (int i = 0; i < facCount; i++)
            Faculties[i].Display();
    }

    // Composition destroy
    public void DeleteUniversity()
    {
        Departments = null;     // Departments destroyed
        Console.WriteLine("\nUniversity & all Departments destroyed!");
    }
}

class UniversityFaculty
{
    static void Main()
    {
        University uni = new University("Tech University", 5, 5);

        Faculty f1 = new Faculty("Rohit", "Computer Science");
        Faculty f2 = new Faculty("Aman", "Mathematics");

        uni.AddDepartment("IT");
        uni.AddDepartment("HR");

        uni.AddFaculty(f1);    // Aggregation
        uni.AddFaculty(f2);

        uni.ShowUniversity();

        uni.DeleteUniversity();   // Departments destroyed

        // Faculty still exists independently
        Console.WriteLine("\nFaculty still exists:");
        f1.Display();
        f2.Display();
    }
}
