using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.ID = 01;
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();

            employee.things = new List<string>()
            { "yo", "homeslice"};
            foreach (string Dud in employee.things)
            {
                Console.WriteLine(Dud);
            }

            Employee<int> employee1 = new Employee<int>();
            employee1.ID = 02;
            employee1.firstName = "Sample";
            employee1.lastName = "stUdent";
            employee1.SayName();

            employee1.things = new List<int>() { 23, 77 };
            foreach (int Udu in employee1.things)
            {
                Console.WriteLine(Udu);
            }

            IQuittable employee2 = new Employee<string>();
            employee2.Quit();
        
            Console.WriteLine("Are the employee and employee1 ID's equal to each other? " //not necessary, for readability
                             + (employee.ID == employee1.ID)); //using overloaded operator
                                    
        }
    }
}
