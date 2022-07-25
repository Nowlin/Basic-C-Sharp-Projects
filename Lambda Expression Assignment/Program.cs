using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { firstName = "Joe", lastName = "DiMaggio", employeeID = 1 },
                new Employee { firstName = "Joe", lastName = "Swanson", employeeID = 2 },
                new Employee { firstName = "Joe", lastName = "Pesci", employeeID = 6 },
                new Employee { firstName = "Joe", lastName = "Rogan", employeeID = 9 },
                new Employee { firstName = "Joe", lastName = "Biden", employeeID = 13 },
                new Employee { firstName = "Joe", lastName = "Montana", employeeID = 22 },
                new Employee { firstName = "Joe", lastName = "Lieberman", employeeID = 14 },
                new Employee { firstName = "Sam", lastName = "Worthington", employeeID = 26 },
                new Employee { firstName = "Chris", lastName = "Evans", employeeID = 18 },
                new Employee { firstName = "Benedict", lastName = "Cumberbatch", employeeID = 29 },
            };

            List<Employee> newList = new List<Employee>();
            foreach (Employee Joe in employees)
            {
                if (Joe.firstName == "Joe")
                {
                    newList.Add(Joe);
                    Console.WriteLine("First Name: " + Joe.firstName + " Last Name: " + Joe.lastName + " Employee ID: " + Joe.employeeID);
                }
            }

            List<Employee> employees2 = employees.Where(x => x.firstName == "Joe").ToList();
            List<Employee> employees3 = employees.Where(j => j.employeeID > 5).ToList();

        }
    }
}
