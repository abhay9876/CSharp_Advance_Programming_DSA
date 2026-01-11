/*Workflow Engine with Dynamic Steps
Use Case: A document approval workflow system executes multiple steps (validate, review,
approve) in sequence.
Why LinkedList? Each step is a node; can be dynamically inserted/removed.
OOP Concepts:
● Interface: WorkflowStep defines a step.
● Polymorphism: Steps vary but follow same interface.
● Abstraction & Encapsulation: Workflow logic is hidden from the user.*/


using System;

// Interface
public interface IStep
{
    void Do();
}
public class Check : IStep
{
    public void Do()
    {
        Console.WriteLine("Checking document");
    }
}

public class Review : IStep
{
    public void Do()
    {
        Console.WriteLine("Reviewing document");
    }
}



public class Approve : IStep
{
    public void Do()
    {
        Console.WriteLine("Approving document");
    }
}


public class StepItem
{
    public IStep Data;
    public StepItem Next;

    public StepItem(IStep data)
    {
        Data = data;
        Next = null;
    }
}

public class Flow
{
    private StepItem head, tail;

    public void Add(IStep step)
    {
        StepItem item = new StepItem(step);

        if (head == null)
        {
            head = tail = item;
            return;
        }

        tail.Next = item;
        tail = item;
    }

    public void Run()
    {
        StepItem temp = head;
        while (temp != null)
        {
            temp.Data.Do();   
            temp = temp.Next;
        }
    }
}