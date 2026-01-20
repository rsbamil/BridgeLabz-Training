// 20-1-26
// LC - 59
public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        int[][] arr = new int[n][];
        for (int i = 0; i < n; i++)
        {
            arr[i] = new int[n];
        }

        int minr = 0;
        int maxr = n - 1;
        int minc = 0;
        int maxc = n - 1;

        int total_ele = n * n;
        int count = 0;
        int a = 1;

        while (count < total_ele)
        {
            for (int i = minc; i <= maxc && count < total_ele; i++)
            {
                arr[minr][i] = a++;
                count++;
            }
            minr++;

            for (int i = minr; i <= maxr && count < total_ele; i++)
            {
                arr[i][maxc] = a++;
                count++;
            }
            maxc--;

            for (int i = maxc; i >= minc && count < total_ele; i--)
            {
                arr[maxr][i] = a++;
                count++;
            }
            maxr--;

            for (int i = maxr; i >= minr && count < total_ele; i--)
            {
                arr[i][minc] = a++;
                count++;
            }
            minc++;
        }

        return arr;
    }
}
