var a = new Node(10);
var b = new Node(20);
var c = new Node(30);
var d = new Node(40);
var e = new Node(50);

a.Next = b;
b.Next = c;
c.Next = d;
d.Next = e;

Console.WriteLine(Reverse(a));

static int Reverse(Node? head)
{
    Node? previous = null;
    Node? current = head;

    while (current != null)
    {
        var next = current.Next;
        current.Next = previous;
        previous = current;
        current = next;
    }
    return previous.Value;
}

public class Node
{
    public Node(int value)
    {
        Value = value; 
    }

    public int Value { get; set; }
    public Node? Next { get; set; }
}

