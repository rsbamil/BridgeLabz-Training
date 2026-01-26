using System;

class HospitalUnit
{
    public string Name;
    public bool IsAvailable;
    public HospitalUnit Next;

    public HospitalUnit(string name, bool isAvailable)
    {
        Name = name;
        IsAvailable = isAvailable;
        Next = null;
    }
}

class AmbulanceRoute
{
    private HospitalUnit head = null;

    // Add a unit to circular linked list
    public void AddUnit(string name, bool isAvailable)
    {
        HospitalUnit newUnit = new HospitalUnit(name, isAvailable);

        if (head == null)
        {
            head = newUnit;
            newUnit.Next = head;
            return;
        }

        HospitalUnit temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newUnit;
        newUnit.Next = head;
    }

    // Find nearest available unit
    public void RedirectPatient()
    {
        if (head == null)
        {
            Console.WriteLine("No hospital units available.");
            return;
        }

        HospitalUnit temp = head;
        do
        {
            if (temp.IsAvailable)
            {
                Console.WriteLine("Patient redirected to: " + temp.Name);
                return;
            }
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("No units currently available.");
    }

    // Remove a unit under maintenance
    public void RemoveUnit(string name)
    {
        if (head == null) return;

        HospitalUnit curr = head;
        HospitalUnit prev = null;

        do
        {
            if (curr.Name == name)
            {
                if (curr == head)
                {
                    HospitalUnit last = head;
                    while (last.Next != head)
                        last = last.Next;

                    head = head.Next;
                    last.Next = head;
                }
                else
                {
                    prev.Next = curr.Next;
                }

                Console.WriteLine(name + " removed (Under Maintenance)");
                return;
            }

            prev = curr;
            curr = curr.Next;

        } while (curr != head);
    }

    // Display circular route
    public void DisplayRoute()
    {
        if (head == null) return;

        HospitalUnit temp = head;
        Console.Write("🏥 Route: ");
        do
        {
            Console.Write(temp.Name + " -> ");
            temp = temp.Next;
        } while (temp != head);
        Console.WriteLine("(Back to Emergency)");
    }
}

class Ambulance
{
    static void Main()
    {
        AmbulanceRoute route = new AmbulanceRoute();

        route.AddUnit("Emergency", false);
        route.AddUnit("Radiology", false);
        route.AddUnit("Surgery", true);
        route.AddUnit("ICU", false);

        route.DisplayRoute();

        route.RedirectPatient();

        route.RemoveUnit("Radiology");

        route.DisplayRoute();

        route.RedirectPatient();
    }
}
