namespace ConsoleApp1;
class Node
{
    public int element;
    public Node next;
    public Node(int e,Node n)
    {
        //Console.WriteLine($"Creating the Node of the Linked List with Element {e}");
        element = e;
        next = n;
    }
}
