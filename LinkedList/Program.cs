using System;
namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            //// BRowsing History
            //BrowsingHistory bh = new BrowsingHistory();
            //bh.AddPage("C# Core");
            //bh.AddPage("C# OOPs");
            //bh.AddPage("C# Advance");
            //bh.Backward();
            //bh.Backward();
            //bh.Farward();
            //bh.Farward();
            //bh.History();

            ////Music Playlist
            //Music m = new Music();
            //m.AddMusicAtFirst("Last Leaves of autumn");
            //m.AddMusicAtLast("Attention");
            //m.AddMusicAtLast("BlackOut");
            //m.AddMusicAtLast("SAU PAULO");
            //m.AddMusicAtLast("All We Know");
            //m.AddMusicAtFirst("On The Floor");
            //m.PlayNext();
            //m.PlayNext();
            //m.PlayNext();
            //m.Playlist();
            //m.RemoveFirst();
            //m.RemoveLast();
            //m.Playlist();



            //TextEditor editor = new TextEditor();
            //editor.Write("Abhay");
            //editor.Write("Zeno");
            //editor.Write("Goku");
            //editor.Undo(); 
            //editor.Undo(); 
            //editor.Undo(); 

            //// Call Center Queue
            //CallCenterQueue queue = new CallCenterQueue();
            //queue.Add("Chat Ticket");
            //queue.Add("Call Ticket");
            //queue.Add("Email Ticket");
            //queue.Remove();
            //queue.Remove();
            //queue.Remove();



            //// Train Route 
            //TrainRoute route = new TrainRoute();
            //route.AddStation("Mathura");
            //route.AddStation("Agra");
            //route.AddStation("Noida");
            //route.ShowRoute();
            //route.RemoveStation();
            //route.ShowRoute();
            //route.ReverseRoute();
            //route.ShowRoute();


            //// Priority Schedular
            //PriorityScheduler scheduler = new PriorityScheduler();
            //scheduler.AddTask("Frontend Task", 2);
            //scheduler.AddTask("Backend Task", 1);
            //scheduler.AddTask("Report Task", 3);
            //scheduler.ExecuteTask(); 
            //scheduler.ExecuteTask(); 
            //scheduler.ExecuteTask();


            //UserFeed feed = new UserFeed();
            //feed.AddNotification("Message Notification");
            //feed.AddNotification("Alarm Notification");
            //feed.DisplayFeed();



            //SimpleLRU cache = new SimpleLRU();
            //cache.Put(1, 10);
            //cache.Put(2, 20);
            //cache.Put(3, 30);
            //Console.WriteLine(cache.Get(2));
            //cache.Put(4, 40); 


            //NotificationQueue queue = new NotificationQueue();
            //queue.Add(new Email());
            //queue.Add(new SMS());
            //queue.Add(new Push());
            //queue.SendAll();


            //OrderQueue queue = new OrderQueue();
            //queue.Add(new Online());
            //queue.Add(new Offline());
            //queue.Add(new Subscription());
            //queue.ProcessAll();

            //JobQueue queue = new JobQueue();
            //queue.Add(new DataSyncJob());
            //queue.Add(new EmailAlertJob());
            //queue.Add(new CleanupJob());
            //queue.RunAll();


            //SupportQueue queue = new SupportQueue();
            //queue.AddRequest(new Chat());
            //queue.AddRequest(new Call());
            //queue.AddRequest(new Emails());
            //queue.ServeNext();
            //queue.ServeNext();
            //queue.ServeNext();

            RetryQueue queue = new RetryQueue();
            queue.Add(new SMSRetry());
            queue.Add(new EmailRetry());
            queue.RetryAll();

        }
    }
}