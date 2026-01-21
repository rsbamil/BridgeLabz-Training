using System;
using System.Collections.Generic;

/* ========== POLICY CLASS ========== */

class InsurancePolicy : IComparable<InsurancePolicy>
{
    public string PolicyNumber;
    public string CoverageType;
    public DateTime ExpiryDate;

    public InsurancePolicy(string number, string coverage, DateTime expiry)
    {
        PolicyNumber = number;
        CoverageType = coverage;
        ExpiryDate = expiry;
    }

    // Needed for SortedSet (TreeSet equivalent)
    public int CompareTo(InsurancePolicy other)
    {
        return this.ExpiryDate.CompareTo(other.ExpiryDate);
    }

    // Needed for HashSet uniqueness
    public override bool Equals(object obj)
    {
        return obj is InsurancePolicy p &&
               PolicyNumber == p.PolicyNumber;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }

    public override string ToString()
    {
        return PolicyNumber + " | " + CoverageType + " | " + ExpiryDate.ToShortDateString();
    }
}

/* ========== MAIN ========== */

class InsurancePolicyManagementSystem
{
    static void Main()
    {
        // 1️⃣ HashSet → unique policies, fast lookup
        HashSet<InsurancePolicy> uniquePolicies = new HashSet<InsurancePolicy>();

        // 2️⃣ LinkedHashSet simulation → preserve insertion order
        List<InsurancePolicy> insertionOrder = new List<InsurancePolicy>();

        // 3️⃣ SortedSet → sorted by expiry date
        SortedSet<InsurancePolicy> sortedByExpiry =
            new SortedSet<InsurancePolicy>();

        AddPolicy(uniquePolicies, insertionOrder, sortedByExpiry,
            new InsurancePolicy("P101", "Health", DateTime.Now.AddDays(20)));

        AddPolicy(uniquePolicies, insertionOrder, sortedByExpiry,
            new InsurancePolicy("P102", "Vehicle", DateTime.Now.AddDays(60)));

        AddPolicy(uniquePolicies, insertionOrder, sortedByExpiry,
            new InsurancePolicy("P103", "Health", DateTime.Now.AddDays(10)));

        // Duplicate policy
        AddPolicy(uniquePolicies, insertionOrder, sortedByExpiry,
            new InsurancePolicy("P101", "Health", DateTime.Now.AddDays(20)));

        /* ========= RETRIEVAL ========= */

        Console.WriteLine("All Unique Policies:");
        foreach (var p in uniquePolicies)
            Console.WriteLine(p);

        Console.WriteLine("\nPolicies Expiring Within 30 Days:");
        foreach (var p in sortedByExpiry)
        {
            if ((p.ExpiryDate - DateTime.Now).Days <= 30)
                Console.WriteLine(p);
        }

        Console.WriteLine("\nPolicies with Health Coverage:");
        foreach (var p in uniquePolicies)
        {
            if (p.CoverageType == "Health")
                Console.WriteLine(p);
        }

        Console.WriteLine("\nInsertion Order (LinkedHashSet behavior):");
        foreach (var p in insertionOrder)
            Console.WriteLine(p);
    }

    static void AddPolicy(HashSet<InsurancePolicy> set,
                          List<InsurancePolicy> order,
                          SortedSet<InsurancePolicy> sorted,
                          InsurancePolicy policy)
    {
        // Detect duplicate by policy number
        if (set.Add(policy))
        {
            order.Add(policy);
            sorted.Add(policy);
        }
        else
        {
            Console.WriteLine("Duplicate policy detected: " + policy.PolicyNumber);
        }
    }
}
