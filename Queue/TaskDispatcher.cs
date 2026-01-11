/*4.Task Dispatcher for Background Workers
Use Case: Queue tasks like file uploads, analytics, or logs to background workers.
OOP Concepts:
● Interface: BackgroundTask
● Encapsulation: TaskQueue shields queue logic.
● Polymorphism: Different tasks (upload, report) use same interface.*/



using System;

public interface BackgroundTask
{
    void Execute();
}


public class FileUpload : BackgroundTask
{
    public void Execute()
    {
        Console.WriteLine("File Upload Task executed...");
    }
}
public class Analytic : BackgroundTask
{
    public void Execute()
    {
        Console.WriteLine(" Analytics Task executed...");
    }
}

public class Log : BackgroundTask
{
    public void Execute()
    {
        Console.WriteLine("Log Task executed...");
    }
}

public class TaskQueue
{
    private Queue<BackgroundTask> tasks = new Queue<BackgroundTask>();

    public void AddTask(BackgroundTask task)
    {
        tasks.Enqueue(task);
        Console.WriteLine("Task Successfully add in queue.");
    }

    public void Process()
    {
        while (tasks.Count > 0)
        {
            BackgroundTask task = tasks.Dequeue();
            task.Execute();
        }
    }
}
