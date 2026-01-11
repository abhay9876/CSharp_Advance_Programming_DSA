using System;
namespace Queue
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Job Print
            PrintQueue pq = new PrintQueue();
            Printable p1 = new Text("Resume.pdf");
            Printable p2 = new Image("Photo.png");
            Printable p3 = new Text("Notes.txt");
            pq.PrintPerform(p1);
            pq.PrintPerform(p2);
            pq.PrintPerform(p3);
            pq.Process();


            // Ticket Booking system
            TicketRequest t1 = new Train();
            TicketRequest t2 = new Bus();
            TicketRequest t3 = new Flight();
            TicketRequest t4 = new Train();
            TicketRequest t5 = new Bus();
            TicketRequest t6 = new Flight();
            TicketBooking tb = new TicketBooking();
            tb.RequestAccess(t1);
            tb.RequestAccess(t2);
            tb.RequestAccess(t3);
            tb.RequestAccess(t4);
            tb.RequestAccess(t5);
            tb.RequestAccess(t6);
            tb.Process();


            // Task Dispacher
            TaskQueue dispatcher = new TaskQueue();
            BackgroundTask t1 = new FileUpload();
            BackgroundTask t2 = new Analytic();
            BackgroundTask t3 = new Log();
            dispatcher.AddTask(t1);
            dispatcher.AddTask(t2);
            dispatcher.AddTask(t3);
            dispatcher.Process();



            // Call Center Management
            CallCenterManager m = new CallCenterManager();
            CallRequest c1 = new SupportCall();
            CallRequest c2 = new SalesCall();
            CallRequest c3 = new FeedbackCall();
            m.ReceiveCall(c1);
            m.ReceiveCall(c2);
            m.ReceiveCall(c3);
            m.ProcessCalls();
        }
    }
}