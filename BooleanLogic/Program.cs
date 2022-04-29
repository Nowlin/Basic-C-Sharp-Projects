using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("To determine whether or not to approve a client's car insurance request, please fill in the following data.");
            Console.WriteLine("What is the client's age?");
            int clientAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have they ever had a DUI, True or False?");
            bool clientDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets have they been given?");
            int clientTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is the client qualified?");
            Console.WriteLine(clientAge > 15 && clientDUI == false && clientTickets <= 3);
            Console.ReadLine();
        }
    }
}
