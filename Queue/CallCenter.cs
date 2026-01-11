/*5.Call Center Management System
Use Case: Incoming calls are queued for available agents.
OOP Concepts:
● Interface: CallRequest
● Polymorphism: Calls could be SupportCall, SalesCall, etc.
● Encapsulation: Queue handling hidden inside CallCenterManager.*/

using System;

public interface CallRequest
{
    void HandleCall();
}

public class SupportCall : CallRequest
{
    public void HandleCall()
    {
        Console.WriteLine("Support call is being handled by support agent.");
    }
}

public class SalesCall : CallRequest
{
    public void HandleCall()
    {
        Console.WriteLine("Sales call is being handled by sales agent.");
    }
}

public class FeedbackCall : CallRequest
{
    public void HandleCall()
    {
        Console.WriteLine("Feedback call is being handled by management team.");
    }
}

public class CallCenterManager
{
    private Queue<CallRequest> calls = new Queue<CallRequest>();

    public void ReceiveCall(CallRequest call)
    {
        calls.Enqueue(call);
        Console.WriteLine("Incoming call added to queue.");
    }

    public void ProcessCalls()
    {
        while (calls.Count > 0)
        {
            CallRequest call = calls.Dequeue();
            call.HandleCall();
        }
    }
}


