/*Scenario 3: Undo Feature in Text Editor
Use Case: Every edit is stored and can be undone step-by-step.
Why LinkedList? LIFO structure fits Stack backed by LinkedList.
OOP Concepts:

● Encapsulation: Each change is encapsulated as a state.
● Abstraction: Undo/redo methods simplify complexity.
● Inheritance: State can be a base class for text/image editing.*/



using System;

public class EditNode
{
    public string Data;
    public EditNode Next;

    public EditNode(string data)
    {
        Data = data;
        Next = null;
    }
}

// Abstraction
public abstract class FeatureUndo
{
    public abstract void Undo();
}

public class TextEditor : FeatureUndo
{
    private EditNode top;

    public void Write(string text)
    {
        EditNode newNode = new EditNode(text);
        newNode.Next = top;
        top = newNode;
    }

    public override void Undo()
    {
        if (top == null)
        {
            Console.WriteLine("Nothing to undo");
            return;
        }

        Console.WriteLine("Undo: " + top.Data);
        top = top.Next;
    }
}
