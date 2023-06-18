
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
        }
        else
        {
            Node? newHead = new Node(value);
            newHead.next = head;
            head = newHead;
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
        Console.WriteLine("enter number of nodes");
        int nodes = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < nodes; i++)
        {
            Console.Write("enter input {0}:", i + 1);
            int input = Convert.ToInt32(Console.ReadLine());
            newlist.AddLast(input);

        }
        newlist.Display();
    }
}