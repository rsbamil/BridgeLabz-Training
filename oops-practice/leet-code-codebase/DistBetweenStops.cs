using System;

class Solution
{
    public int DistanceBetweenBusStops(int[] distance, int start, int destination)
    {
        int totalSum = 0;

        for (int i = 0; i < distance.Length; i++)
        {
            totalSum += distance[i];
        }

        int targetSum = 0;

        if (start < destination)
        {
            for (int i = start; i < destination; i++)
            {
                targetSum += distance[i];
            }
        }
        else
        {
            for (int i = destination; i < start; i++)
            {
                targetSum += distance[i];
            }
        }

        return Math.Min(targetSum, totalSum - targetSum);
    }
}
