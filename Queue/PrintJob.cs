/*Print Job Manager
Use Case: Print requests are handled in the order they are received.
OOP Concepts:
● Interface: Printable
● Encapsulation: PrintQueue class hides internal state.
● Polymorphism: Could be TextDocument, ImageFile, etc.*/



using System;

public interface Printable
{
	void Print();
}

public class Text : Printable
{
    private string text;
    public Text(string text)
    {
        this.text = text;
    }
    public void Print()
	{
		Console.WriteLine($"Text File {text} is printing");
	}
}

public class Image : Printable
{
    private string image;

    public Image(string image)
    {
        this.image = image;
    }
    public void Print()
    {
        Console.WriteLine($"Image File : {image} is printing");
    }
}


public class PrintQueue
{
	private Queue<Printable> queue = new Queue<Printable>();

	public void PrintPerform(Printable p)
	{
        queue.Enqueue(p);
        Console.WriteLine("file added to print Queue.");
	}

    public void Process()
    {
        while (queue.Count > 0)
        {
            Printable p = queue.Dequeue();
            p.Print();
        }
    }
}
