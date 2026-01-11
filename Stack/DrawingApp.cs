/*4.Undo Functionality in Drawing App
Use Case: Maintain stack of actions (line drawn, shape added) and support undo.
OOP Concepts:
● Interface: DrawingAction
● Polymorphism: Multiple actions (line, circle, erase) handled uniformly.
● Encapsulation: Undo stack wrapped inside the app logic.*/



using System;


public interface DrawingAction
{
	void Perform();
	void Undo();
}

public class Line : DrawingAction
{
  public void Perform()
	{
		Console.WriteLine("Line Draw... ");
	}

	public void Undo()
	{
		Console.WriteLine(" Line Removed...");
	}
}

public class Circle : DrawingAction
{
    public void Perform()
    {
        Console.WriteLine(" Circle Draw... ");
    }

    public void Undo()
    {
        Console.WriteLine(" Circle Removed... .");
    }
}

public class Erase : DrawingAction
{
    public void Perform()
    {
        Console.WriteLine(" Erased ... ");
    }

    public void Undo()
    {
        Console.WriteLine(" Erased Undo ... .");
    }
}

public class DrawingApp 
{
	private Stack<DrawingAction> shapes = new Stack<DrawingAction>();
	
	public void ActionPerform(DrawingAction da)
	{
        da.Perform();
        shapes.Push(da);
	}
    

	public void Undo()
	{
		if(shapes.Count == 0)
		{
			Console.WriteLine($"Nothing to Erase ..");
		}
		else
		{
            DrawingAction action = shapes.Pop();
            action.Undo();
		}
	}
}

