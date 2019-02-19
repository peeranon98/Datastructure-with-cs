using System;

public class Stack // First in last out
{
    internal LinkedList list = new LinkedList();
	public Stack()
	{
	}
    public void push(Object data)
    {
        list.addLast(data);
    }
    public object pop()
    {
        if (list.size == 0)
        {
            Console.WriteLine("Error");
            return null;
        }
        else
        {
            Object temp = list.tail.data;
            list.removeLast();
            return temp;
        }
        
    }
}

public class Queue // First in First out
{
    internal LinkedList list = new LinkedList();
    public Queue()
    {
    }
    public void enqueue(Object data)
    {
        list.addLast(data);
    }
    public object dequeue()
    {
        if (list.size == 0)
        {
            Console.WriteLine("Error");
            return null;
        }
        else
        {
            Object temp = list.head.data;
            list.removeFirst();
            return temp;
        }
    }
}