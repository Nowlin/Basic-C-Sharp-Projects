using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Sample = new Employee();
            Sample.FirstName = "Sample";
            Sample.LastName = "Student";
            Sample.SayName();
        }
    }
}
