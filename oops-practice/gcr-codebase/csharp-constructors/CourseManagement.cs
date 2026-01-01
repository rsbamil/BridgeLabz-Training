using System;
class Course
{
    string courseName;
    int duration;
    int fee;
    static string instituteName = "ABC Institute";
    public Course(string courseName, int duration, int fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Course Name: " + courseName + ", Duration: " + duration + " months, Fee: $" + fee + ", Institute: " + instituteName);
    }
    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
    }
}
class CourseManagement
{
    static void Main()
    {
        Course c1 = new Course("Java", 6, 600);
        Course c2 = new Course("Python", 4, 400);
        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();
        Course.UpdateInstituteName("XYZ Academy");
        Course c3 = new Course("C++", 5, 500);
        c3.DisplayCourseDetails();
    }
}