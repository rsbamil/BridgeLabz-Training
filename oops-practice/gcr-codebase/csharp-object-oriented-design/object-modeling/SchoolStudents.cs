using System;

public class Course
{
    public string CourseName;
    public Student[] Students = new Student[10];
    int stuCount = 0;

    public Course(string name)
    {
        CourseName = name;
    }

    public void AddStudent(Student s)
    {
        Students[stuCount++] = s;
    }

    public void ShowStudents()
    {
        Console.WriteLine("\nCourse: " + CourseName + " Students:");
        for (int i = 0; i < stuCount; i++)
        {
            Console.WriteLine("   " + Students[i].Name);
        }
    }
}

public class Student
{
    public string Name;
    public Course[] Courses = new Course[10];
    int courseCount = 0;

    public Student(string name)
    {
        Name = name;
    }

    // Association between Student and Course
    public void EnrollCourse(Course c)
    {
        Courses[courseCount++] = c;
        c.AddStudent(this);
    }

    public void ShowCourses()
    {
        Console.WriteLine("\nStudent: " + Name + " Enrolled Courses:");
        for (int i = 0; i < courseCount; i++)
        {
            Console.WriteLine("   " + Courses[i].CourseName);
        }
    }
}

public class School
{
    public string SchoolName;
    public Student[] Students;
    int count = 0;

    public School(string name, int size)
    {
        SchoolName = name;
        Students = new Student[size];
    }

    // Aggregation: School HAS students (but doesn’t own their life)
    public void AddStudent(Student s)
    {
        Students[count++] = s;
    }

    public void ShowStudents()
    {
        Console.WriteLine("\nSchool: " + SchoolName + " Students:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(" - " + Students[i].Name);
        }
    }
}

class SchoolStudents
{
    static void Main()
    {
        School school = new School("Green Valley School", 5);

        Student s1 = new Student("Rohit");
        Student s2 = new Student("Aman");

        Course c1 = new Course("Mathematics");
        Course c2 = new Course("Computer Science");

        school.AddStudent(s1);
        school.AddStudent(s2);

        s1.EnrollCourse(c1);
        s1.EnrollCourse(c2);
        s2.EnrollCourse(c2);

        school.ShowStudents();
        s1.ShowCourses();
        s2.ShowCourses();
        c2.ShowStudents();
    }
}
