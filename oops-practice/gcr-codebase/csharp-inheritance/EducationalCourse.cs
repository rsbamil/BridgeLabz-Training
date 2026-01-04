using System;

class Course
{
    public string CourseName;
    public int Duration; // in hours

    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }

    public virtual void DisplayCourse()
    {
        Console.WriteLine("Course Name : " + CourseName);
        Console.WriteLine("Duration    : " + Duration + " Hours");
    }
}

class OnlineCourse : Course
{
    public string Platform;
    public bool IsRecorded;

    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }

    public override void DisplayCourse()
    {
        base.DisplayCourse();
        Console.WriteLine("Platform    : " + Platform);
        Console.WriteLine("Recorded    : " + IsRecorded);
    }
}

class PaidOnlineCourse : OnlineCourse
{
    public double Fee;
    public double Discount;

    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }

    public override void DisplayCourse()
    {
        base.DisplayCourse();
        Console.WriteLine("Fee         : ₹" + Fee);
        Console.WriteLine("Discount    : " + Discount + "%");
        Console.WriteLine("Final Price : ₹" + (Fee - (Fee * Discount / 100)));
    }
}

class EducationalCourse
{
    static void Main()
    {
        PaidOnlineCourse course = new PaidOnlineCourse(
            "Full Stack Development",
            120,
            "Udemy",
            true,
            15000,
            20
        );

        course.DisplayCourse();
    }
}
