using System;

class StudentNode
{
    public int RollNumber;
    public string Name;
    public int Age;
    public char Grade;
    public StudentNode Next;

    public StudentNode(int rollNumber, string name, int age, char grade)
    {
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentLinkedList
{
    private StudentNode head = null;

    public void AddAtBeginning(int rollNumber, string name, int age, char grade)
    {
        StudentNode newNode = new StudentNode(rollNumber, name, age, grade);
        newNode.Next = head;
        head = newNode;

        Console.WriteLine("Student added at beginning.");
    }

    public void AddAtEnd(int rollNumber, string name, int age, char grade)
    {
        StudentNode newNode = new StudentNode(rollNumber, name, age, grade);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            StudentNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        Console.WriteLine("Student added at end.");
    }

    public void AddAtPosition(int position, int rollNumber, string name, int age, char grade)
    {
        if (position < 1)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        if (position == 1)
        {
            AddAtBeginning(rollNumber, name, age, grade);
            return;
        }

        StudentNode newNode = new StudentNode(rollNumber, name, age, grade);
        StudentNode temp = head;

        for (int i = 1; i < position - 1; i++)
        {
            if (temp == null)
            {
                Console.WriteLine("Position out of range.");
                return;
            }
            temp = temp.Next;
        }

        newNode.Next = temp.Next;
        temp.Next = newNode;

        Console.WriteLine("Student added at position " + position);
    }

    public void DeleteByRollNumber(int rollNumber)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (head.RollNumber == rollNumber)
        {
            head = head.Next;
            Console.WriteLine("Student deleted.");
            return;
        }

        StudentNode temp = head;

        while (temp.Next != null && temp.Next.RollNumber != rollNumber)
        {
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            Console.WriteLine("Student not found.");
        }
        else
        {
            temp.Next = temp.Next.Next;
            Console.WriteLine("Student deleted.");
        }
    }

    public void SearchByRollNumber(int rollNumber)
    {
        StudentNode temp = head;

        while (temp != null)
        {
            if (temp.RollNumber == rollNumber)
            {
                Console.WriteLine("\nStudent Found:");
                Console.WriteLine("Roll Number: " + temp.RollNumber);
                Console.WriteLine("Name: " + temp.Name);
                Console.WriteLine("Age: " + temp.Age);
                Console.WriteLine("Grade: " + temp.Grade);
                return;
            }

            temp = temp.Next;
        }

        Console.WriteLine("Student not found.");
    }

    public void UpdateGrade(int rollNumber, char newGrade)
    {
        StudentNode temp = head;

        while (temp != null)
        {
            if (temp.RollNumber == rollNumber)
            {
                temp.Grade = newGrade;
                Console.WriteLine("Grade updated.");
                return;
            }

            temp = temp.Next;
        }

        Console.WriteLine("Student not found.");
    }

    public void DisplayAllRecords()
    {
        if (head == null)
        {
            Console.WriteLine("No student records available.");
            return;
        }

        StudentNode temp = head;

        Console.WriteLine("\nSTUDENT RECORDS:");

        while (temp != null)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Roll Number: " + temp.RollNumber);
            Console.WriteLine("Name: " + temp.Name);
            Console.WriteLine("Age: " + temp.Age);
            Console.WriteLine("Grade: " + temp.Grade);

            temp = temp.Next;
        }

        Console.WriteLine("----------------------------");
    }
}

class StudentManagementSystem
{
    static void Main()
    {
        StudentLinkedList list = new StudentLinkedList();

        while (true)
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Add Student at Beginning");
            Console.WriteLine("2. Add Student at End");
            Console.WriteLine("3. Add Student at Position");
            Console.WriteLine("4. Delete Student by Roll Number");
            Console.WriteLine("5. Search Student by Roll Number");
            Console.WriteLine("6. Update Student Grade");
            Console.WriteLine("7. Display All Records");
            Console.WriteLine("8. Exit");

            Console.Write("Enter Choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent(list, "beginning");
                    break;

                case 2:
                    AddStudent(list, "end");
                    break;

                case 3:
                    Console.Write("Enter Position: ");
                    int pos = int.Parse(Console.ReadLine());
                    AddStudentAtPosition(list, pos);
                    break;

                case 4:
                    Console.Write("Enter Roll Number to Delete: ");
                    int delRoll = int.Parse(Console.ReadLine());
                    list.DeleteByRollNumber(delRoll);
                    break;

                case 5:
                    Console.Write("Enter Roll Number to Search: ");
                    int searchRoll = int.Parse(Console.ReadLine());
                    list.SearchByRollNumber(searchRoll);
                    break;

                case 6:
                    Console.Write("Enter Roll Number: ");
                    int upRoll = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Grade: ");
                    char newGrade = char.Parse(Console.ReadLine());
                    list.UpdateGrade(upRoll, newGrade);
                    break;

                case 7:
                    list.DisplayAllRecords();
                    break;

                case 8:
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }

    static void AddStudent(StudentLinkedList list, string type)
    {
        Console.Write("Enter Roll Number: ");
        int roll = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter Grade: ");
        char grade = char.Parse(Console.ReadLine());

        if (type == "beginning")
            list.AddAtBeginning(roll, name, age, grade);
        else
            list.AddAtEnd(roll, name, age, grade);
    }

    static void AddStudentAtPosition(StudentLinkedList list, int position)
    {
        Console.Write("Enter Roll Number: ");
        int roll = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter Grade: ");
        char grade = char.Parse(Console.ReadLine());

        list.AddAtPosition(position, roll, name, age, grade);
    }
}
