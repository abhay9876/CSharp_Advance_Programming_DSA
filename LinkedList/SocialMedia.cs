/*Social Media Notification Feed
Use Case: Store and display recent notifications for a user in reverse chronological order
(most recent first).
Why LinkedList? Fast insert at the beginning and sequential traversal.
OOP Concepts:
● Encapsulation: User feed is managed privately.
● Abstraction: API-style access to addNotification() and displayFeed().
● Inheritance/Polymorphism: Different types of notifications (LikeNotification,
CommentNotification) can be handled generically.*/


using System;

public class Notification
{
    public string Message;
    public Notification Next;

    public Notification(string msg)
    {
        Message = msg;
        Next = null;
    }
}

// Abstraction
public abstract class Feed
{
    public abstract void AddNotification(string text);
    public abstract void DisplayFeed();
}


public class UserFeed : Feed
{
    private Notification head;

    public override void AddNotification(string text)
    {
        Notification newNode = new Notification(text);
        newNode.Next = head;
        head = newNode;
    }
    public override void DisplayFeed()
    {
        Notification temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Message);
            temp = temp.Next;
        }
    }
}
