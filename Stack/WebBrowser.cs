/*Web Browser Tab Navigation (Back/Forward Tabs)
Use Case: Users can navigate back and forward between opened tabs.
OOP Concepts:
● Interface: NavigationManager
● Encapsulation: Two stacks handle navigation state.
● Polymorphism: Could extend for mobile vs desktop browser.*/


using System;

interface NavigationManager
{
	void VisitTab(string tabName);
	string BackWard();
	string ForWard();
	string Current();
}
public class DesktopNavigation : NavigationManager
{
	private Stack<string> BackStack = new Stack<string>();
	private Stack<string> ForStack = new Stack<string>();
	private string CurrentTab;
	 public DesktopNavigation(string current)
	{
		CurrentTab = current;
	}

	public void VisitTab(string tab)
	{
		BackStack.Push(CurrentTab);
		CurrentTab = tab;
		Console.WriteLine($"{CurrentTab} is Opened ...");
	}

	public string BackWard()
	{
		if(BackStack.Count() == 0)
		{
			return CurrentTab;
		}
		ForStack.Push(CurrentTab);
		CurrentTab = BackStack.Pop();
		return CurrentTab;

    }

	public string ForWard()
	{
		if(ForStack.Count() == 0)
		{
			return CurrentTab;
		}

		BackStack.Push(CurrentTab);
		CurrentTab = ForStack.Pop();
        return CurrentTab;
    }

	public string Current()
	{
		return CurrentTab;
	}


}
