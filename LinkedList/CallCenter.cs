
/*Customer Service Call Center Queue
Use Case: Handle customer support tickets in order of arrival.
Why LinkedList? FIFO nature can be modeled via a queue using LinkedList.
OOP Concepts:
● Abstraction: Add/remove operations for ticket queue.
● Encapsulation: Each ticket is hidden behind methods.
● Polymorphism: Different ticket types (chat, call, email) handled similarly.*/


using System;

public class TicketNode
{
    public string Data;
    public TicketNode Next;

    public TicketNode(string data)
    {
        Data = data;
        Next = null;
    }
}

public abstract class TicketQueue
{
    public abstract void Add(string ticket);
    public abstract void Remove();
}

public class CallCenterQueue : TicketQueue
{
    private TicketNode front, rear;

    public override void Add(string ticket)
    {
        TicketNode newNode = new TicketNode(ticket);

        if (rear == null)
        {
            front = rear = newNode;
            return;
        }

        rear.Next = newNode;
        rear = newNode;
    }


    public override void Remove()
    {
        if (front == null)
        {
            Console.WriteLine("No ticket..");
            return;
        }

        Console.WriteLine("Serving : " + front.Data);
        front = front.Next;

        if (front == null)
            rear = null;
    }
}
