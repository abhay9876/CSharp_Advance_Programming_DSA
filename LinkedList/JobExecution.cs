/*Job Execution System with Executable Interface
Use Case: Background service that executes various jobs like data sync, email alerts, cleanup,
etc.
OOP Concepts:
● Interface: Executable allows different jobs to be plugged in.
● LinkedList: Manages job queue.
● Abstraction & Polymorphism: Execute method is uniform, logic varies.*/



using System;

// Interface
public interface IExecutable
{
    void Execute();
}

public class DataSyncJob : IExecutable
{
    public void Execute()
    {
        Console.WriteLine("Running Data Job");
    }
}

public class EmailAlertJob : IExecutable
{
    public void Execute()
    {
        Console.WriteLine("Sending Email Alerts");
    }
}



public class CleanupJob : IExecutable
{
    public void Execute()
    {
        Console.WriteLine("Performing Cleanup");
    }
}


public class JobBox
{
    public IExecutable Data;
    public JobBox Next;

    public JobBox(IExecutable data)
    {
        Data = data;
        Next = null;
    }
}

public class JobQueue
{
    private JobBox front, rear;

    public void Add(IExecutable job)
    {
        JobBox box = new JobBox(job);

        if (rear == null)
        {
            front = rear = box;
            return;
        }

        rear.Next = box;
        rear = box;
    }
    public void RunAll()
    {
        while (front != null)
        {
            front.Data.Execute();   
            front = front.Next;
        }
    }
}