using System;
interface ITrackable
{
    void StartTracking();
    void StopTracking();
}
class UserProfile : ITrackable
{
    private string UserName;
    private int Age;
    private string MembershipType;
    public string userName
    {
        get { return UserName; }
        set { UserName = value; }
    }
    public int age
    {
        get { return Age; }
        set { Age = value; }
    }
    public string membershipType
    {
        get { return MembershipType; }
        set { MembershipType = value; }
    }
    public override string ToString()
    {
        return "UserName :" + userName + ", Age :" + age + ", MembershipType :" + membershipType;
    }
    public void StartTracking()
    {
        Console.WriteLine("Tracking started for " + UserName);
        Console.WriteLine("Calories will be monitored.");
    }
    public void StopTracking()
    {
        Console.WriteLine("Tracking stopped for " + UserName);
        Console.WriteLine("Calories burned are 350 kcal.");
    }
}
class WorkOut
{
    private string WorkoutType;
    private int Duration; // in minutes
    public string workoutType
    {
        get { return WorkoutType; }
        set { WorkoutType = value; }
    }
    public int duration
    {
        get { return Duration; }
        set { Duration = value; }
    }
    public override string ToString()
    {
        return "WorkoutType :" + workoutType + ", Duration :" + duration + " minutes";
    }
}
class CardioWorkout : WorkOut
{
    public override string ToString()
    {
        return "Cardio - " + base.ToString();
    }

}
class StrengthWorkout : WorkOut
{
    public override string ToString()
    {
        return "Strength - " + base.ToString();
    }

}
class FitnessTracker
{
    static void Main()
    {
        // User profile
        UserProfile user = new UserProfile
        {
            userName = "Rohit",
            age = 23,
            membershipType = "Premium"
        };

        Console.WriteLine(user);
        user.StartTracking();

        // Cardio workout
        WorkOut cardio = new CardioWorkout
        {
            workoutType = "Running",
            duration = 30
        };

        // Strength workout
        WorkOut strength = new StrengthWorkout
        {
            workoutType = "Weight Training",
            duration = 45
        };

        Console.WriteLine(cardio);
        Console.WriteLine(strength);

        user.StopTracking();
    }
}