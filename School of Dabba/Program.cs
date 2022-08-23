using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace School_of_Yabba
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
