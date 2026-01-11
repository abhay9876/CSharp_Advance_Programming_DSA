
/*Notification Retry Mechanism
Use Case: Failed notifications (e.g., SMS or email) are retried after failure in FIFO order.
Why LinkedList? Keeps retry order simple and efficient.
OOP Concepts:
● Interface: RetryableTask for various retry operations.
● Polymorphism: Allows different task types to be retried uniformly.
● Abstraction: Retry logic is hidden.
● Encapsulation: Linked list maintains retry queue.*/

using System;

public interface IRetryableTask
{
    void Retry();
}

public class SMSRetry : IRetryableTask
{
    public void Retry()
    {
        Console.WriteLine("Retrying SMS Notification");
    }
}

public class EmailRetry : IRetryableTask
{
    public void Retry()
    {
        Console.WriteLine("Retrying Email Notifications");
    }
}

public class RetryBox
{
    public IRetryableTask Data;
    public RetryBox Next;

    public RetryBox(IRetryableTask data)
    {
        Data = data;
        Next = null;
    }
}

public class RetryQueue
{
    private RetryBox front, rear;

    public void Add(IRetryableTask task)
    {
        RetryBox box = new RetryBox(task);

        if (rear == null)
        {
            front = rear = box;
            return;
        }

        rear.Next = box;
        rear = box;
    }

    public void RetryAll()
    {
        while (front != null)
        {
            front.Data.Retry();  
            front = front.Next;
        }
    }
}