/*Scenario 2: Music Playlist Queue
Use Case: A music player plays songs one after another and can dynamically add/remove
songs.
Why LinkedList? Dynamic addition/removal from both ends.
OOP Concepts:
● Encapsulation: Playlist data is secured.
● Abstraction: Methods like playNext(), addSong() simplify usage.
● Polymorphism: If we extend MediaPlayer, it could play videos, podcasts, etc.*/




using System;

public class Node
{
	public string Data;
	public Node next;
	public Node(string data)
	{
		Data = data;
		next = null;
	}
}

public abstract class Feature
{
	public abstract void PlayNext();
	//public abstract void AddSong();
}

public class Music : Feature
{
	Node Head,temp;
	Node Curr;

	public void AddMusicAtFirst(string musicName)
	{
		if(Head == null)
		{
			Node node = new Node(musicName);
			Curr = node;
			Head = node;
			temp = node;
			Console.WriteLine($"{musicName} Song Added At First...");
		}
		else
		{
			Node node = new Node(musicName);
			node.next = Head;
			Head = node;
			temp = Head;
            Console.WriteLine($"{musicName} Song Added At First...");
        }
	}
    public void AddMusicAtLast(string musicName)
    {
        if (Head == null)
        {
            Node node = new Node(musicName);
            Curr = node;
            Head = node;
            temp = node;
            Console.WriteLine($"{musicName} Song Added At Last...");
        }
        else
        {
            Node node = new Node(musicName);
            Curr.next = node;
            Curr = node;
            Console.WriteLine($"{musicName} Song Added At Last...");
        }
    }

    public override void PlayNext()
	{
		temp = temp.next;
		Console.WriteLine($"Playing Song  :  {temp.Data}");
	}

	public void RemoveFirst()
	{
        Console.WriteLine($"{Head.Data} Song Removed At First...");
        Head = Head.next;
		temp = Head;
        
    }

	public void RemoveLast()
	{
		temp = Head;
		while(temp.next != Curr)
		{
			temp = temp.next;
		}
        Console.WriteLine($"{Curr.Data} Song Removed At Last...");
        Curr = temp;
		Curr.next = null;
		temp = Head;
	}

	public void Playlist()
	{
        Console.WriteLine($"Musicccccc PlayList....");
        temp = Head;
		while(temp!= null)
		{
			Console.Write($"{temp.Data}  -->  ");
			temp = temp.next;
		}
        Console.Write("null");
        Console.WriteLine();
		temp = Head;
	}
}
