/*Ticket Booking System Queue
Use Case: Ticket requests (flight, train) are processed in sequence.
OOP Concepts:
● Interface: TicketRequest
● Encapsulation: Request queue managed inside a service.
● Abstraction & Polymorphism: Works for bus/train/flight with common interface.*/


using System;

public interface TicketRequest
{
    void TicketRequestSend();
	void TicketRequests();
}

public class Bus : TicketRequest
{
    public void TicketRequestSend()
    {
        Console.WriteLine("Bus Ticket Request Successfully send.");
    }
	public void TicketRequests()
	{
		Console.WriteLine("Bus Ticket Request Accepted.");
	}
}

public class Flight : TicketRequest
{
    public void TicketRequestSend()
    {
        Console.WriteLine("Flight Ticket Request Successfully send.");
    }

    public void TicketRequests()
    {
        Console.WriteLine("Flight Ticket Request Accepted.");
    }
}

public class Train : TicketRequest
{
    public void TicketRequestSend()
    {
        Console.WriteLine("Train Ticket Request Successfully send.");
    }

    public void TicketRequests()
    {
        Console.WriteLine("Train Ticket Request Accepted.");
    }
}

public class TicketBooking
{
    private Queue<TicketRequest> requests = new Queue<TicketRequest>();

    public void RequestAccess(TicketRequest tr)
    {
        requests.Enqueue(tr);
        tr.TicketRequestSend();
    }

    public void Process()
    {
        while(requests.Count > 0)
        {
            TicketRequest req = requests.Dequeue();
            req.TicketRequests();
        }
    }
	
}
