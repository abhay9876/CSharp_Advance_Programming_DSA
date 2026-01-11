using System;

public class Station
{
    public string Name;
    public Station Next;

    public Station(string name)
    {
        Name = name;
        Next = null;
    }
}

// Abstraction
public abstract class Route
{
    public abstract void AddStation(string name);
    public abstract void RemoveStation();
    public abstract void ReverseRoute();
    public abstract void ShowRoute();
}

public class TrainRoute : Route
{
    private Station head;

    public override void AddStation(string name)
    {
        Station newNode = new Station(name);

        if (head == null)
        {
            head = newNode;
            return;
        }
        Station temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newNode;
    }

    public override void RemoveStation()
    {
        if (head == null) return;

        if (head.Next == null)
        {
            head = null;
            return;
        }

        Station temp = head;
        while (temp.Next.Next != null)
            temp = temp.Next;

        temp.Next = null;
    }

    public override void ReverseRoute()
    {
        Station prev = null, current = head, next = null;

        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }

        head = prev;
    }

    public override void ShowRoute()
    {
        Station temp = head;
        while (temp != null)
        {
            Console.Write(temp.Name + "--> ");
            temp = temp.Next;
        }
        Console.WriteLine("End....");
    }
}