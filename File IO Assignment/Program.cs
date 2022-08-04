using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It would be great if you would enter a number....");
            int log = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\s_now\logs\log.txt", true))
            {
                file.WriteLine(log);
            }
            string log2 = File.ReadAllText(@"C:\Users\s_now\logs\log.txt");
            Console.WriteLine(log2);
        }
    }
}
