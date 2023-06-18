using System;

namespace ConsoleApp8;

public class Node
{
    public int? data;
    public Node? next;
    public Node(int value)
    {
        data = value;
        next = null;
    }

}

public class DoubleLinkedList
{
    public static Node? head;

    public DoubleLinkedList()
    {
        head = null;
    }

    public void AddFirst(int value)
    {
        if (head == null)
        {
            head = new Node(value);
            head.next = head;
        }
        else
        {
            Node newHead = new Node(value);
            newHead.next = head;




            Node current = head;
            while (current.next != head)
            {
                current = current.next;

            }
            head = newHead;
            current.next = head;



        }
    }
    public void AddLast(int value)
    {

        if (head == null)
        {
            head = new Node(value);
            head.next = head;
        }
        else
        {
            Node current = head;
            Node newNode = new Node(value);

            while (current.next != head)
            {
                current = current.next;

            }
            current.next = newNode;
            newNode.next = head;


        }
    }
    public void Display()
    {
        int count = 0;
        Node currentHead = head;
        Console.WriteLine("Data entered in the list are :");

        do
        {
            Console.Write("node number {0}:", ++count);
            Console.WriteLine(currentHead.data);
            currentHead = currentHead.next;
        }
        while (currentHead != head);

    }


}

public class program
{
    public static void Main(string[] args)
    {
        DoubleLinkedList newlist = new DoubleLinkedList();
        newlist.AddLast(1);
        newlist.AddLast(2);
        newlist.AddLast(3);
        newlist.AddLast(4);
        newlist.AddLast(5);
        Console.Write("enter input");
        int input = Convert.ToInt32(Console.ReadLine());
        newlist.AddLast(input);


        newlist.Display();
    }
}
