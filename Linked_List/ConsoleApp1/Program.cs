using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1;
class LinkedList
{
    private Node head;
    private Node tail;
    private int size;
    public LinkedList()
    {
        head = null;
        tail = null;
        size = 0;

    }
    public int length()
    {
        return size;
    }

    public bool isEmpty()
    {
        return size == 0;
    }

    public void addLast(int e)
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

    public void display()
    {
        Node p = head;
        while (p != null)
        {
            Console.Write(p.element+" -->");
            p = p.next;
        }
        Console.WriteLine();
    }

    //Inserting element at beginning -> Time Complexity -> O(1)
    public void addStart(int e)
    {
        Node newest = new Node(e, null);
        if (isEmpty())
        {
            head = newest;
            tail = newest;
        }
        else
        {
            newest.next = head;
            head = newest;
        }
        size++;
    }

    //Insert Anywhere in the list
    public void addAny(int e,int position)
    {
        Node newest = new Node(e, null);
        if (position<=0 || position > size)
        {
            Console.WriteLine("Invalid position");
            return;
        }
        Node p = head;
        int i = 1;
        while (i <= position - 1)
        {
            p = p.next;
            i++;
        }
        newest.next = p.next;
        p.next = newest;
        size++;
    }


    //Delete from beginning in the list
    public int RemoveFirst()
    {
        if(isEmpty())
        {
            Console.WriteLine("Node is already Empty!!");
            return -1;
        }
        int e = head.element;
        head = head.next;
        if (isEmpty())
        {
            tail.next = null;
        }
        return e;
            size--;
    }
    //Delete from end in the list
    public int Removeany()
    {
        if (isEmpty())
        {
            Console.WriteLine("Node is already Empty!!");
            return -1;
        }
        Node n = head;
        int i = 1;
        while (i<=size-1)
        {
            n = n.next;
            i++;
        }
        tail = n;
        n = n.next;
        size--;
        tail.next = null;
        return n.element; 
    }

    //Delete from anywhere in the list
    public int RemoveAny(int position)
    {
        if (isEmpty())
        {
            Console.WriteLine("Node is already Empty!!");
            return -1;
        }
        int i = 1;
        Node p = head;
        while (i <= position - 1)
        {
            p = p.next;
            i++;
        }
        int e = p.next.element;
        p.next = p.next.next;
        size--;
        return e;     
    }
    //Searching the element in the Linked list
    public int Search(int e)
    {
        if (isEmpty())
        {
            Console.WriteLine("Node is already Empty!!");
            return -1;
        }
        int i = 0;
        Node p = head;
        while (p)
        {
            if(p.element == e)
            {
                return i;
            }
            p = p.next;
            i++;
        }
        return -1;
    }



    static void Main(string[] args)
    {
        LinkedList l = new LinkedList();
        l.addLast(7);
        l.addLast(4);
        l.addLast(12);
        l.display();
        Console.WriteLine("Size of List: "+l.length());
        l.addLast(47);
        l.addLast(45);
        l.addLast(14);
        l.display();
        Console.WriteLine("Size of List: " + l.length());

    }
}
