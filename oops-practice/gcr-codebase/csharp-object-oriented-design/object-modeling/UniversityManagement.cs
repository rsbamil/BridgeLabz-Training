using System;

public class Course
{
    public string CourseName;
    public Student[] Students = new Student[10];
    public Professor AssignedProfessor;
    int sCount = 0;

    public Course(string name)
    {
        CourseName = name;
    }

    public void AddStudent(Student s)
    {
        Students[sCount++] = s;
    }

    public void ShowCourseDetails()
    {
        Console.WriteLine("\nCourse: " + CourseName);

        Console.WriteLine(" Professor: " + AssignedProfessor.ProfName);

        Console.WriteLine(" Enrolled Students:");
        for (int i = 0; i < sCount; i++)
        {
            Console.WriteLine("   " + Students[i].Name);
        }
    }
}

public class Student
{
    public string Name;
    public Course[] Courses = new Course[10];
    int cCount = 0;

    public Student(string name)
    {
        Name = name;
    }

    // Association + Communication
    public void EnrollCourse(Course c)
    {
        Courses[cCount++] = c;
        c.AddStudent(this);
        Console.WriteLine(Name + " enrolled in " + c.CourseName);
    }

    public void ShowMyCourses()
    {
        Console.WriteLine("\nStudent: " + Name + " Courses:");
        for (int i = 0; i < cCount; i++)
        {
            Console.WriteLine("   " + Courses[i].CourseName);
        }
    }
}

public class Professor
{
    public string ProfName;

    public Professor(string name)
    {
        ProfName = name;
    }

    // Communication
    public void AssignProfessor(Course c)
    {
        c.AssignedProfessor = this;
        Console.WriteLine(ProfName + " is now teaching " + c.CourseName);
    }
}

class UniversityManagement
{
    static void Main()
    {
        Student s1 = new Student("Rohit");
        Student s2 = new Student("Aman");

        Professor p1 = new Professor("Dr. Sharma");

        Course c1 = new Course("Computer Science");
        Course c2 = new Course("Mathematics");

        s1.EnrollCourse(c1);
        s2.EnrollCourse(c1);
        s1.EnrollCourse(c2);

        p1.AssignProfessor(c1);
        p1.AssignProfessor(c2);

        s1.ShowMyCourses();
        s2.ShowMyCourses();
        c1.ShowCourseDetails();
    }
}
