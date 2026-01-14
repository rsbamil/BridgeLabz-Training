using System;
using System.Diagnostics;
using System.Text;

class StringConcat
{
    static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };

        foreach (int n in sizes)
        {
            Console.WriteLine("\nOperations Count: " + n);

            // STRING CONCATENATION
            if (n <= 10000) // avoid freezing system
            {
                MeasureTime("string", () =>
                {
                    string s = "";
                    for (int i = 0; i < n; i++)
                    {
                        s += "a";
                    }
                });
            }
            else
            {
                Console.WriteLine("string: Skipped (Too Slow / O(N²))");
            }

            // STRINGBUILDER
            MeasureTime("StringBuilder", () =>
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < n; i++)
                {
                    sb.Append("a");
                }
                string result = sb.ToString();
            });

            // THREAD-SAFE STRINGBUILDER (StringBuffer equivalent)
            MeasureTime("StringBuilder (Thread-Safe)", () =>
            {
                StringBuilder sb = new StringBuilder();
                object lockObj = new object();

                for (int i = 0; i < n; i++)
                {
                    sb.Append("a");
                }
                string result = sb.ToString();
            });
        }
    }

    static void MeasureTime(string name, Action action)
    {
        Stopwatch sw = Stopwatch.StartNew();
        action();
        sw.Stop();
        Console.WriteLine(name + " " + sw.ElapsedMilliseconds + " ms");
    }
}
