using System;

namespace Classes_and_Methods_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CMAClass Add = new CMAClass();
            Console.WriteLine(Add.Add(3));
            Console.WriteLine(Add.Deci(4.35m));
            Console.WriteLine(Add.String("5"));
        }
    }
}
