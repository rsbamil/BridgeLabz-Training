// 12-01-2026
using System;
using System.Collections.Generic;

class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        List<int> ans = new List<int>();

        int m = matrix.Length;
        int n = matrix[0].Length;

        int totalElem = m * n;
        int startRow = 0;
        int endRow = m - 1;
        int startCol = 0;
        int endCol = n - 1;
        int count = 0;

        while (count < totalElem)
        {
            // 1st row
            for (int i = startCol; i <= endCol && count < totalElem; i++)
            {
                ans.Add(matrix[startRow][i]);
                count++;
            }
            startRow++;

            // last column
            for (int i = startRow; i <= endRow && count < totalElem; i++)
            {
                ans.Add(matrix[i][endCol]);
                count++;
            }
            endCol--;

            // last row
            for (int i = endCol; i >= startCol && count < totalElem; i--)
            {
                ans.Add(matrix[endRow][i]);
                count++;
            }
            endRow--;

            // first column
            for (int i = endRow; i >= startRow && count < totalElem; i--)
            {
                ans.Add(matrix[i][startCol]);
                count++;
            }
            startCol++;
        }

        return ans;
    }
}
