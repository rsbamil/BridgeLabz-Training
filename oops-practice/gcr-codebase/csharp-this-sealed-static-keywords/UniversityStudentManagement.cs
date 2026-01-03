using System;
class Student
{
    static string UniversityName = "XYZ University";
    static int totalStudents = 0;
    readonly int rollNumber;
    string name;
    double grade;
    public Student(int rollNumber, string name, double grade)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.grade = grade;
        totalStudents++;
    }
    public void DisplayStudentInfo()
    {
        Console.WriteLine("Roll Number: " + rollNumber + ", Name: " + name + ", Grade: " + grade + ", University: " + UniversityName);
    }
    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students: " + totalStudents);
    }
}
class UniversityStudentManagement
{
    static void Main()
    {
        Student s1 = new Student(101, "RK", 9.5);
        Student s2 = new Student(102, "DEV", 9.5);
        if (s1 is Student)
        {
            Console.WriteLine("s1 is an instance of Student");
            s1.DisplayStudentInfo();
        }
        if (s2 is Student)
        {
            Console.WriteLine("s2 is an instance of Student");
            s2.DisplayStudentInfo();
        }
        Student.DisplayTotalStudents();
    }
}