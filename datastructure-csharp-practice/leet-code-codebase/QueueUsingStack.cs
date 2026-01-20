// 20-1-26
// LC - 232
using System.Collections.Generic;


public class MyQueue
{
    Stack<int> inp = new Stack<int>();
    Stack<int> outp = new Stack<int>();
    int peekEl = -1;

    public MyQueue()
    {
    }

    public void Push(int x)
    {
        if (inp.Count == 0)
        {
            peekEl = x;
        }
        inp.Push(x);
    }

    public int Pop()
    {
        if (outp.Count == 0)
        {
            while (inp.Count > 0)
            {
                outp.Push(inp.Pop());
            }
        }
        return outp.Pop();
    }

    public int Peek()
    {
        if (outp.Count == 0)
        {
            return peekEl;
        }
        return outp.Peek();
    }

    public bool Empty()
    {
        return inp.Count == 0 && outp.Count == 0;
    }
}
