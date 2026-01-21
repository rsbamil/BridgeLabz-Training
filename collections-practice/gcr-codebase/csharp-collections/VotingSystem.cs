using System;
using System.Collections.Generic;

class VotingSystem
{
    static void Main()
    {
        // 1️ Dictionary to store votes
        Dictionary<string, int> voteCount = new Dictionary<string, int>();

        // 2️ List to maintain insertion order (LinkedHashMap behavior)
        List<string> voteOrder = new List<string>();

        CastVote(voteCount, voteOrder, "Alice");
        CastVote(voteCount, voteOrder, "Bob");
        CastVote(voteCount, voteOrder, "Alice");
        CastVote(voteCount, voteOrder, "Charlie");
        CastVote(voteCount, voteOrder, "Bob");

        // 3️ SortedDictionary to display results in order
        SortedDictionary<string, int> sortedResults =
            new SortedDictionary<string, int>(voteCount);

        Console.WriteLine("Votes in Insertion Order (LinkedHashMap behavior):");
        foreach (string candidate in voteOrder)
        {
            Console.WriteLine(candidate);
        }

        Console.WriteLine("\nFinal Vote Count:");
        foreach (var pair in voteCount)
        {
            Console.WriteLine(pair.Key + " : " + pair.Value);
        }

        Console.WriteLine("\nSorted Results:");
        foreach (var pair in sortedResults)
        {
            Console.WriteLine(pair.Key + " : " + pair.Value);
        }
    }

    static void CastVote(Dictionary<string, int> votes,
                         List<string> order,
                         string candidate)
    {
        order.Add(candidate);

        if (votes.ContainsKey(candidate))
            votes[candidate]++;
        else
            votes[candidate] = 1;
    }
}
