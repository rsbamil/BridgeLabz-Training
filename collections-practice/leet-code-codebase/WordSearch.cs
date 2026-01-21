// 21-1-26
// LC 79
using System;

public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        int m = board.Length;
        int n = board[0].Length;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i][j] == word[0])
                {
                    if (Fun(board, i, j, word, 0, m, n))
                        return true;
                }
            }
        }
        return false;
    }

    public static bool Fun(char[][] board, int row, int col,
                           string word, int idx, int m, int n)
    {
        // base case
        if (idx == word.Length)
            return true;

        if (row < 0 || row >= m ||
            col < 0 || col >= n ||
            board[row][col] != word[idx])
            return false;

        char temp = board[row][col];
        board[row][col] = '#'; // mark visited

        int[] ri = { -1, 0, 0, 1 };
        int[] ci = { 0, -1, 1, 0 };

        for (int i = 0; i < 4; i++)
        {
            if (Fun(board, row + ri[i], col + ci[i],
                    word, idx + 1, m, n))
                return true;
        }

        board[row][col] = temp; // backtrack
        return false;
    }
}
