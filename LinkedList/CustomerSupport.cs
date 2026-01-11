/*Customer Support Chat Queue System
Use Case: Customers are put in a queue to chat with the next available agent.
Why LinkedList? FIFO nature helps maintain order of service.
OOP Concepts:
● Interface: UserRequest for any type of request (chat, call, email).
● Polymorphism: Different request types handled uniformly.
● Encapsulation: Request queue is managed privately.
● Abstraction: Simple API to add/request service.*/

using System;

// Interface
public interface IUserRequest
{
    void Handle();
}

public class Chat : IUserRequest
{
    public void Handle()
    {
        Console.WriteLine("Handling Chat Request");
    }
}


public class Call : IUserRequest
{
    public void Handle()
    {
        Console.WriteLine("Handling Call Request");
    }
}

public class Emails : IUserRequest
{
    public void Handle()
    {
        Console.WriteLine("Handling Email Request");
    }
}
public class RequestBox
{
    public IUserRequest Data;
    public RequestBox Next;

    public RequestBox(IUserRequest data)
    {
        Data = data;
        Next = null;
    }
}

public class SupportQueue
{
    private RequestBox front, rear;

    public void AddRequest(IUserRequest request)
    {
        RequestBox box = new RequestBox(request);

        if (rear == null)
        {
            front = rear = box;
            return;
        }

        rear.Next = box;
        rear = box;
    }

    public void ServeNext()
    {
        if (front == null)
        {
            Console.WriteLine("Nothing in Queue");
            return;
        }

        front.Data.Handle();  
        front = front.Next;
    }
}