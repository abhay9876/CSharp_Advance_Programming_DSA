/*Order Processing System with Interface for Order Types
Use Case: Process different types of orders: online, offline, subscription.
Why LinkedList? Orders arrive sequentially and are processed in FIFO order.
OOP Concepts:
● Interface: Order interface abstracts order types.
● Polymorphism: process() works differently per order type.
● Encapsulation: The order queue is wrapped and secured.*/


using System;

// Interface
public interface IOrder
{
    void Process();
}

public class Online : IOrder
{
    public void Process()
    {
        Console.WriteLine("Online Order......");
    }
}


public class Offline : IOrder
{
    public void Process()
    {
        Console.WriteLine("Offline Order...");
    }
}


public class Subscription : IOrder
{
    public void Process()
    {
        Console.WriteLine(" Subscription Order...");
    }
}

public class OrderBox
{
    public IOrder Data;
    public OrderBox Next;

    public OrderBox(IOrder data)
    {
        Data = data;
        Next = null;
    }
}

public class OrderQueue
{
    private OrderBox front, rear;

    public void Add(IOrder order)
    {
        OrderBox box = new OrderBox(order);

        if (rear == null)
        {
            front = rear = box;
            return;
        }

        rear.Next = box;
        rear = box;
    }
    public void ProcessAll()
    {
        while (front != null)
        {
            front.Data.Process();
            front = front.Next;
        }
    }
}
