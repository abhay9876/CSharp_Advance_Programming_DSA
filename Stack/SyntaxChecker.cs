/*3.Syntax Checker for Code Editors
Use Case: Validate matched parentheses, brackets, or braces ({}, [], ()).
OOP Concepts:
● Interface: SyntaxChecker
● Encapsulation: Stack logic is hidden inside the implementation.
● Polymorphism: Can create multiple syntax checkers for different file types.*/


using System;
interface SyntaxChecker
{
	void SyntaxCheck();
}
public class CodeEditor : SyntaxChecker
{
	private Stack<char> stack = new Stack<char>();
	private string _text;
	public CodeEditor(string text)
	{
		_text = text;
	}


	public void SyntaxCheck()
	{
		for(int i = 0; i < _text.Length; i++)
		{
			char ch = _text[i];
			if(ch == '{' || ch == '['|| ch == '(')
			{
				stack.Push(ch);
			}

			else if(ch == '}' || ch == ']' || ch == ')')
			{
				if(ch == '}' && stack.Peek() == '{')
				{
					stack.Pop();
				}
                else if (ch == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (ch == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
            }
		}

		if(stack.Count == 0)
		{
			Console.WriteLine($"No Syntax Error..");
		}
		else
		{
            Console.WriteLine($"Syntax Error..");
        }
	}
}
