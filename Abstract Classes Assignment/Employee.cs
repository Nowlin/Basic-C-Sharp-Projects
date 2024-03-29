﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    public class Employee<T> : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("I QUIT!!!!!!!");
        }
        public int ID { get; set; }
        public static bool operator ==(Employee<T> employee, Employee<T> employee1)
        {
            if (employee.ID == employee1.ID)
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee<T> employee, Employee<T> employee1)
        {
            return employee.ID != employee1.ID; 
        }
        public List<T> things { get; set; }
    }
}
