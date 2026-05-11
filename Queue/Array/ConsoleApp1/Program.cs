//namespace ConsoleApp1;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Hello, World!");
//    }
//}


namespace ConsoleApp1;

class QueueArray
{
    int[] data;
    int front;
    int tail;
    int size = 0;

    public QueueArray(int n)
    {
        data = new int[n];
        front = 0;
        tail = 0;

    }

    public int length()
    {
        return size; ;
    }

    public bool isEmpty()
    {
        return size == 0;
    }

    public bool isFull()
    {
        return size == data.Length;
    }

    public void enqueue(int e)
    {
        if (isFull())
        {
            Console.WriteLine("Stack is full");
            return;
        }
        else
        {
            data[tail] = e;
            tail++;
            size++;
        }

    }

    public int dequeue()
    {
        if (isEmpty())
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
        else
        {
            int e = data[front];
            front++;
            size--;
            return e;
        }
    }

    public int first()
    {
        if (isEmpty())
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
        else
        {
            return data[front];
        }
    }


    public void display()
    {
        int p = front;
        while (p <= tail-1)
        {
            Console.WriteLine(data[p]);
            p++;
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        QueueArray l = new QueueArray(10);
        Console.WriteLine("Enqueuing the elements");
        l.enqueue(13);
        l.enqueue(23);
        l.enqueue(323);
        l.enqueue(403);
        l.enqueue(32);
        l.enqueue(24);
        l.enqueue(465);
        Console.WriteLine();
        Console.WriteLine("Checking the first element in the queue");
        Console.WriteLine("First element in queue: " + l.first());
        Console.WriteLine();
        Console.WriteLine("Dsiplaying the element");
        l.display();
        Console.WriteLine();
        Console.WriteLine("Dequeuing the elements");
        Console.WriteLine("Dequeued Element: " + l.dequeue());
        Console.WriteLine("Dequeued Element: " + l.dequeue());
        Console.WriteLine("Dequeued Element: " + l.dequeue());
        Console.WriteLine("Dequeued Element: " + l.dequeue());
        Console.WriteLine();
        Console.WriteLine("Dsiplaying the element");
        l.display();
        Console.WriteLine("Checking the first element in the queue");
        Console.WriteLine("First element in queue: " + l.first());
    }
}