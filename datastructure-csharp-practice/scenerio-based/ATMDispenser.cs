using System;

class ATMDispenser
{
    // Method to dispense cash based on available notes
    static void DispenseCash(int amount, int[] notes)
    {
        // Array to hold count of each note dispensed
        int[] noteCount = new int[notes.Length];
        // Variable to track remaining amount
        int remainingAmount = amount;

        // Calculate the number of each note to dispense
        for (int i = notes.Length - 1; i >= 0; i--)
        {
            // Calculate the number of notes for each denomination
            if (remainingAmount >= notes[i])
            {
                noteCount[i] = remainingAmount / notes[i];
                // Update the remaining amount
                remainingAmount %= notes[i];
            }
        }

        Console.WriteLine("Requested Amount: Rs " + amount);
        Console.WriteLine("Dispensed Notes:");
        // Display the notes dispensed
        int totalDispensed = 0;
        for (int i = notes.Length - 1; i >= 0; i--)
        {
            if (noteCount[i] > 0)
            {
                Console.WriteLine(notes[i] + " x " + noteCount[i]);
                totalDispensed += notes[i] * noteCount[i];
            }
        }

        // Check if exact change is possible
        if (remainingAmount == 0)
        {
            Console.WriteLine("Exact amount dispensed.");
        }
        else
        {
            Console.WriteLine("Exact change not possible.");
            Console.WriteLine("Dispensed: Rs " + totalDispensed);
            Console.WriteLine("Remaining: Rs " + remainingAmount);
        }
        // Calculate total number of notes dispensed
        int totalNotes = 0;
        for (int i = 0; i < noteCount.Length; i++)
        {
            totalNotes += noteCount[i];
        }
        Console.WriteLine("Total number of notes dispensed: " + totalNotes);

        Console.WriteLine("----------------------------------");
    }

    static void Main()
    {
        Console.Write("Enter the amount to withdraw:\n");
        int amount = int.Parse(Console.ReadLine());
        // Scenario A
        int[] notesScenarioA = { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
        Console.WriteLine("SCENARIO A: All Notes Available");
        DispenseCash(amount, notesScenarioA);

        // Scenario B (₹500 removed)
        int[] notesScenarioB = { 1, 2, 5, 10, 20, 50, 100, 200 };
        Console.WriteLine("SCENARIO B: Rs 500 Removed");
        DispenseCash(amount, notesScenarioB);

        // Scenario C (Exact change not possible example)
        int[] notesScenarioC = { 5, 10, 20, 50, 100, 200 };
        Console.WriteLine("SCENARIO C: Fallback Example");
        DispenseCash(amount, notesScenarioC);
    }
}
