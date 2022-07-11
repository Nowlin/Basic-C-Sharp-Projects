using System;

namespace Class_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            CMA YoDude = new CMA();
            Console.WriteLine("Please enter a number................");
            int YoDude2 = Convert.ToInt32(Console.ReadLine());
            YoDude.Divide(YoDude2);
        }
    }
}
