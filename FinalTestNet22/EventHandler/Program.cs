using System;

namespace EventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write classes for events, one class which exposes an event and another which handles the event.
1)    Create a class to pass as an argument for the event handlers
2)    Set up the delegate for the event
3)    Declare the code for the event
4)    Create code the will be run when the event occurs
5)    Associate the event with the event handler
             * */
            var FrontDesk = new FrontDesk();
            var ReceiveGuest= new ReceiveGuest();
            ReceiveGuest.GuestEvent += FrontDesk.LogTime;
            ReceiveGuest.Greeting();

        }
    }
    public class FrontDesk
    {
        public void LogTime(object sender, GuestCheckInEventArgs ea)
        {
            Console.WriteLine("The guest has arrived at {0}", ea.time);
        }

    }

    public class ReceiveGuest
    {
        public event GuestCheckInEventHandeler GuestEvent;

        public void Greeting()
        {
            Console.WriteLine("Welcome to the Hotel");
            GuestCheckInEventHandeler Guest = GuestEvent;
            if (GuestEvent != null)
            {
                Guest(this, new GuestCheckInEventArgs(DateTime.Now));
            }

        }
    }
    public delegate void GuestCheckInEventHandeler(object sender, GuestCheckInEventArgs ea);
    public class GuestCheckInEventArgs : EventArgs
    {
        public DateTime time { get; set; }
        public GuestCheckInEventArgs(DateTime time)
        {
            this.time = time;
        }
    }
}
