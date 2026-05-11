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

    //Adding the element at the last of the circular linked list
    public void addLast(int e)
    {
        Node newest = new Node(e, null);
        if (isEmpty())
        {
            newest.next = newest;
            head = newest;
        }
        else
        {
            newest.next = tail.next;
            tail.next = newest;
        }
        tail = newest;
        size++;
    //    Console.WriteLine("Node added to the list");
    }

    //Adding the element at the first of the circular linked list
    public void addFirst(int e)
    {
        Node newest = new Node(e, null);
        if (isEmpty())
        {
            newest.next = newest;
            head = newest;
            tail = newest;
        }
        else
        {
            tail.next = newest;
            newest.next = head;
            head = newest;
        }
        size++;
        //    Console.WriteLine("Node added to the list");
    }


    //adding elements anywhere in the linked list
    public void addAny(int e, int position)
    {
        Node newest = new Node(e, null);
        Node p = head;
        int i = 1;
        while(i<=position - 1)
        {
            p = p.next;
            i++;
        }
        newest.next = p.next;
        p.next = newest;
        size++;
    }

    //remove first element from the list
    public int removeFirst()
    {
        if (isEmpty())
        {
            Console.WriteLine("List already empty");
            return -1;
        }
        int e = head.element;
        tail.next = head.next; 
        head = head.next;
        size--;
        if (isEmpty())
        {
            head = null;
            tail = null;
        }
        return e;
    }

    //remove element from anywhere in the list
    public int removeAny(int position)
    {
        if (isEmpty())
        {
            Console.WriteLine("List already empty");
            return -1;
        }
        int i = 1;
        Node p = head;
        while( i<=position - 1)
        {
            p = p.next;
            i++;
        }
        int e = p.next.element;
        p.next = p.next.next;
        size--;
        return e; 
    }

    //remove element at the end 
    public int removeLast()
    {
        if (isEmpty())
        {
            Console.WriteLine("List already empty");
            return -1;
        }
        Node p = head;
        int i = 1;
        while (i <= size - 1)
        {
            p = p.next;
            i++;
        }
        tail = p;
        p = p.next;
        int e = p.element;
        tail.next = head;
        size--;
        return e;
    }


    //traversing the List
    public void display()
    {
        Node p = head;
        int i = 0;
        while (i< size)
        {
            Console.Write(p.element + "-->");
            p = p.next;
            i++;
        }
    }
    static void Main(string[] args)
    {
        LinkedList p = new LinkedList();
        p.addLast(1);
        p.addLast(4);
        p.addLast(5);
        p.addLast(6);
        p.display();
    }
}

