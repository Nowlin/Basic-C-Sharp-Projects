using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Exception_Handling_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Not supposed to ask this.... but, how old are you?");
            int Age = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (Age > 1 && Age < 100)
                {
                    Console.WriteLine("So... that means you were born in: " + (2022 - Age) + " What was it like in the stone age?");
                }
            }
            catch
            {
                if (Age == 0)
                {
                    throw new ZeroException();
                }
                else if (Age < 0)
                {
                    throw new NegativeException("Ummmmmm........ No.........");
                }
                else
                {
                    throw new Exception("Not sure how you screwed this up.... Gratz on finding a way....!");
                }
            }
        }
    }
}
