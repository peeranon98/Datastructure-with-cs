using System;

public class Node
{
    public Node next;
    public Object data;
    public Node(Object data)
    {
        this.data = data;
        this.next = null;
    }
}

public class LinkedList
{
    internal Node head;
    internal Node tail;
    internal int size;
    public LinkedList()
    {
        this.size = 0;
        this.head = null;
        this.tail = null;
    }
    public void printAllNodes()
    {
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
        //Console.WriteLine("Here");
    }
    public void addFirst(Object data)
    {
        Node newNode = new Node(data);
        newNode.data = data;
        if (size == 0)
        {
            head = tail = newNode;
        }
        else
        {
            Node current = head;
            newNode.next = current;
            head = newNode;
        }
        size++;
    }
    public void addLast(Object data)
    {
        Node newNode = new Node(data);
        newNode.data = data;
        if (size == 0)
        {
            head = tail = newNode;
        }
        else
        {
            Node current = tail;
            current.next = newNode;
            tail = newNode;
        }
        size++;
    }
    public void insertAtindex(int index, Object data)
    {
        Node newNode = new Node(data);
        newNode.data = data;
        if (index > size - 1)
        {
            Console.WriteLine("Index Error");
        }
        else if (index == 0)
        {
            this.addFirst(data);
        }
        else if (index == size - 1)
        {
            this.addLast(data);
        }
        else
        {
            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.next;
            }
            newNode.next = current.next;
            current.next = newNode;
            size++;
        }
    }
    public void removeFirst()
    {
        if (size == 0)
        {
            Console.WriteLine("Error there is nothing in linked list");
        }
        else if (size == 1)
        {
            head = null;
            tail = null;
        }
        else
        {
            Node current = head;
            head = current.next;
            current.next = null;
        }
        size--;
    }
    public void removeLast()
    {
        if (size == 0)
        {
            Console.WriteLine("Error there is nothing in linked list");
        }
        else if (size == 1)
        {
            head = null;
            tail = null;
        }
        else
        {
            Node current = head;
            for (int i = 0; i < size - 2; i++)
            {
                current = current.next;
            }
            tail = current;
            current.next = null;
            
        }
        size--;
    }
    public Object getElementAtIndex(int index)
    {
        Node current = head;
        for (int i = 0; i < index; i++)
        {
            current = current.next;
        }
        return current.data;
    }
    public int findSize()
    {
        return size;
    }
    public bool isEmpty()
    {
        if (size == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}