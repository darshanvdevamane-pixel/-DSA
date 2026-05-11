using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1;

class StacksArray
{
    int[] data;
    int top;

    public StacksArray(int n)
    {
        data = new int[n];
        top = 0;

    }

    public int length()
    {
        return top;
    }

    public bool isEmpty()
    {
        return top == 0;
    }

    public bool isFull()
    {
        return top == data.Length;
    }

    public void push(int e)
    {
        if (isFull())
        {
            Console.WriteLine("Stack is full");
            return;
        }
        else
        {
            data[top] = e;
            top++;
        }
        
    }

    public int pop()
    {
        if (isEmpty())
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
        else
        {
            int e = data[top];
            top--;
            return e;
        }
    }

    public int peek()
    {
        if (isEmpty())
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
        else
        {
            return data[top];
        }
    }


    public void display()
    {
        int p = 0;
        while (p < top) 
        {
            Console.WriteLine(data[p]);
            p++;
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        StacksArray s = new StacksArray(10);
        s.push(3);
        s.push(5);
        s.display();
    }
}
