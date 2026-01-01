using System;
class Student
{
    public int rollNumber;
    protected string name;
    private double CGPA;
    public Student(int rollNumber, string name, double CGPA)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }
    public void DisplayStudentDetails()
    {
        Console.WriteLine("Roll Number: " + rollNumber + ", Name: " + name + ", CGPA: " + CGPA);
    }
    public void ModifyCGPA(double newCGPA)
    {
        CGPA = newCGPA;
    }
}
class PostGraduateStudent : Student
{
    public PostGraduateStudent(int rollNumber, string name, double CGPA) : base(rollNumber, name, CGPA)
    {

    }
    public void DisplayPGStudentDetails()
    {
        // Accessing protected member 'name' from base class
        Console.WriteLine("PostGraduate Student Name: " + name);
    }
}
class UniversityManagementSystem
{
    static void Main()
    {
        Student s1 = new Student(101, "Rohit", 9.0);
        s1.DisplayStudentDetails();
        s1.ModifyCGPA(9.5);
        s1.DisplayStudentDetails();
        PostGraduateStudent pgStudent = new PostGraduateStudent(201, "Dev", 9.2);
        pgStudent.DisplayPGStudentDetails();
    }
}