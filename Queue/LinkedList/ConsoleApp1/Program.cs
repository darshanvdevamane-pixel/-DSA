namespace ConsoleApp1;

class Node
{
    public int element;
    public Node next;
    public Node(int e,Node n)
    {
        element = e;
        next = n;
    }
}
class LinkedQueue
{
    private Node head;
    private Node tail;
    private int size = 0;
    public LinkedQueue()
    {
        head = null;
        tail = null;
    }

    public bool isEmpty()
    {
        return size == 0;
    }

    public void enqueue(int e)
    {
        Node newest = new Node(e, null);
        if (isEmpty())
        {
            head = newest;
        }
        else
        {
            tail.next = newest;
        }
        tail = newest;
        size++;
    }

    public int dequeue()
    {
        if (isEmpty())
        {
            Console.WriteLine("Queue is Empty");
            return -1;
        }
        int n = head.element;
        head = head.next;
        size--;
        if (isEmpty())
        {
            tail = null;
        }
        return n;
    }
    public int first()
    {
        if (isEmpty())
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }
        return head.element;
    }

    public void display()
    {
        Node p = head;
        int i = 0;
        while(i <= size-1)
        {
            Console.WriteLine(p.element);
            p = p.next;
            i++;
        }
    }
    static void Main(string[] args)
    {
        LinkedQueue l = new LinkedQueue();
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
        Console.WriteLine("First element in queue: "+ l.first());
        Console.WriteLine();
        Console.WriteLine("Dsiplaying the element");
        l.display();
        Console.WriteLine();
        Console.WriteLine("Dequeuing the elements");
        Console.WriteLine("Dequeued Element: "+ l.dequeue());
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
