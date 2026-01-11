/*Custom Notification System with Interface and LinkedList
Use Case: Deliver notifications of different types (Email, SMS, Push) and store them in a
delivery queue.
OOP Concepts:
● Interface: Notification interface represents all types.
● Polymorphism: Each notification type handles delivery differently.
● Encapsulation: NotificationQueue hides internal structure.
● Abstraction: Only add() and sendAll() methods are exposed.*/


using System;

// Interface
public interface INotification
{
    void Send();
}

public class Email : INotification
{
    public void Send()
    {
        Console.WriteLine("Email Sent");
    }
}

public class SMS : INotification
{
    public void Send()
    {
        Console.WriteLine("SMS Sent");
    }
}

public class Push : INotification
{
    public void Send()
    {
        Console.WriteLine("Push Notification Sent");
    }
}

public class MessageBox
{
    public INotification Data;
    public MessageBox Next;

    public MessageBox(INotification data)
    {
        Data = data;
        Next = null;
    }
}

public class NotificationQueue
{
    private MessageBox front, rear;

    public void Add(INotification notification)
    {
        MessageBox box = new MessageBox(notification);

        if (rear == null)
        {
            front = rear = box;
            return;
        }

        rear.Next = box;
        rear = box;
    }

    public void SendAll()
    {
        while (front != null)
        {
            front.Data.Send();   
            front = front.Next;
        }
    }
}