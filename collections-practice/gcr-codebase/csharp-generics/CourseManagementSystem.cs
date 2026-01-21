using System;
using System.Collections.Generic;
abstract class CourseType
{
    public abstract string EvaluationType();
}
class ExamCourse : CourseType
{
    public override string EvaluationType()
    {
        return "Exam-based evaluation";
    }
}
class AssignmentCourse : CourseType
{
    public override string EvaluationType()
    {
        return "Assignment-based evaluation";
    }
}
class Course<T> where T : CourseType
{
    public string CourseName;
    List<T> list = new List<T>();
    public Course(string CourseName)
    {
        this.CourseName = CourseName;
    }
    public void AddCourse(T course)
    {
        list.Add(course);
    }
    public void DisplayCourses()
    {
        Console.WriteLine("Course Name: " + CourseName);
        foreach (var course in list)
        {
            Console.WriteLine("Evaluation Type: " + course.EvaluationType());
        }
    }
}
class CourseManagementSystem
{
    static void Main()
    {
        Course<ExamCourse> csCourse = new Course<ExamCourse>("Computer Science");
        csCourse.AddCourse(new ExamCourse());
        Course<AssignmentCourse> artsCourse = new Course<AssignmentCourse>("Arts");
        artsCourse.AddCourse(new AssignmentCourse());
        csCourse.DisplayCourses();
        artsCourse.DisplayCourses();
    }
}