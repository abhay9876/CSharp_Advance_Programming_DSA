/*Scenario 1: Browser History Navigation
Use Case: Maintain a user’s browsing history with the ability to move back and forth.
Why LinkedList? Doubly linked list makes it easy to navigate both backward and forward.
OOP Concepts:
● Encapsulation: Browser history data is wrapped inside a class.
● Abstraction: Navigation methods hide internal implementation.
● Inheritance & Polymorphism: Reusable navigation for other apps like music players.*/



using System;

public class Page
{
	public string data;
	public Page next;
	public Page prev;

	public Page(string data)
	{
		this.data = data;
		next = null;
		prev = null;
	}
}

public abstract class Navigate
{
	public abstract void Farward();
	public abstract void Backward();
}

// Browsing History Class 
public class BrowsingHistory : Navigate
{
	Page head ;
	Page Curr;
	public void AddPage(string data)
	{
		if(Curr == null)
		{
            Page page = new Page(data);
            Curr = page;
			head = page;
        }
		else
		{
			Page page = new Page(data);
            Page temp = Curr;
            Curr = page;
            Curr.prev = temp;

        }
	}

    public override void Farward()
    {

       if(Curr.next != null)
		{
			Page temp = Curr;
			Curr = temp.next;
			Curr.prev = temp;

			Console.WriteLine($"Next Page Data : {Curr.data}");
		}
		else
		{
			Console.WriteLine("Current page is the last page..");
		}
    }
    public override void Backward()
    {
		if (Curr.prev != null)
		{
			Page temp = Curr;
			Curr = temp.prev;
			Curr.next = temp;

			Console.WriteLine($"Previous Page Data : {Curr.data}");
		}
		else
		{
			Console.WriteLine("Current page is the first page..");
		}

    }

	public void History()
	{
		while(head != null)
		{
			Console.Write($"{head.data}  --> ");
			head = head.next;
		}
		Console.Write("null");
	}
}