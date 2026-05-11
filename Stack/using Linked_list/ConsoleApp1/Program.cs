namespace ConsoleApp1;
class LinkedListStack
{
    private Node top;
    private int size = 0;
    public LinkedListStack()
    {
        top = null;
    }
    public bool isEmpty()
    {
        return size == 0;
    }
    public int length()
    {
        return size;
    }
    public void Push(int e)
    {
        Node newest = new Node(e,null);
        if (isEmpty())
        {
            top = newest;
        }
        else
        {
            newest.next = top;
            top = newest;
        }
        size++;
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
            int e = top.element;
            top = top.next;
            size--;
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
        return top.element;
    }

    public void display()
    {
        Node p = top;
        int i = 0;
        while(i <= size - 1)
        {
            Console.WriteLine(p.element);
            p = p.next; 
            i++;
        }
    }

    static void Main(string[] args)
    {
        LinkedListStack l = new LinkedListStack();
        Console.WriteLine("Pushing element to the stack");
        l.Push(10);
        l.Push(20);
        l.Push(30);
        l.Push(40);
        l.Push(190);
        l.Push(50);
        Console.WriteLine("Element's in the stack");
        Console.WriteLine();

        l.display();
        Console.WriteLine();
        Console.WriteLine("Popping the element from the stack");
        Console.WriteLine("Pooped element:" + l.pop());
        Console.WriteLine("Pooped element:" + l.pop());
        Console.WriteLine("Pooped element:" + l.pop());

        Console.WriteLine();
        Console.WriteLine("Peeking in the stack");
        Console.WriteLine("Element at the top:" + l.peek());
        Console.WriteLine();
        Console.WriteLine("Element's in the stack");
        l.display();
    }
}
