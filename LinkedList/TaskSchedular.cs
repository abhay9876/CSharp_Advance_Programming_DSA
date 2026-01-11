/*Task Scheduler with Prioritization

Use Case: A system schedules tasks based on priority, dynamically updating the task queue.
Why LinkedList? Enables dynamic insertion at any position (based on priority).
OOP Concepts:
● Encapsulation: Task data is wrapped securely.
● Abstraction: Methods hide complexity of inserting tasks by priority.
● Polymorphism: Tasks can be of different types (EmailTask, ReportTask).*/


using System;

public class Task
{
    public int Priority;
    public string Name;
    public Task Next;

    public Task(string name, int priority)
    {
        Name = name;
        Priority = priority;
        Next = null;
    }
}

// Abstraction
public abstract class Scheduler
{
    public abstract void AddTask(string name, int priority);
    public abstract void ExecuteTask();
}

public class PriorityScheduler : Scheduler
{
    private Task head;

    public override void AddTask(string name, int priority)
    {
        Task newNode = new Task(name, priority);

        if (head == null || priority < head.Priority)
        {
            newNode.Next = head;
            head = newNode;
            return;
        }
        Task temp = head;
        while (temp.Next != null && temp.Next.Priority <= priority)
            temp = temp.Next;

        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    public override void ExecuteTask()
    {
        if (head == null)
        {
            Console.WriteLine("No Task...");
            return;
        }

        Console.WriteLine("Execute : " + head.Name);
        head = head.Next;
    }
}