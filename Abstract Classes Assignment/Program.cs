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
            Employee employee = new Employee();
            employee.ID = 01;
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();

            Employee employee1 = new Employee();
            employee1.ID = 02;
            employee1.firstName = "Sample";
            employee1.lastName = "stUdent";
            employee1.SayName();

            IQuittable employee2 = new Employee();
            employee2.Quit();

            Console.WriteLine("Are the employee and employee1 ID's equal to each other? " //not necessary, for readability
                             + (employee.ID == employee1.ID)); //using overloaded operator
                                    
        }
    }
}
