using System;

namespace IncomeComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Please input hourly rate for Person 1.");
            decimal personOneA = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please input the hours worked for Person 1.");
            decimal personOneB = Convert.ToDecimal(Console.ReadLine());

            decimal personOne = (personOneA * personOneB);

            Console.WriteLine("Please input hourly rate for Person 2.");
            decimal personTwoA = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please input the hours worked for Person 2.");
            decimal personTwoB = Convert.ToDecimal(Console.ReadLine());

            decimal personTwo = (personTwoA * personTwoB);

            decimal personOneSalary = (personOne * 52);
            Console.WriteLine("Annual Salary of Person 1 is: " + personOneSalary);
            Console.ReadLine();

            decimal personTwoSalary = (personTwo * 52);
            Console.WriteLine("Annual Salary of Person 2 is: " + personTwoSalary);
            Console.ReadLine();

            Console.WriteLine("Person 1 makes more money than Person 2: " + (personOneSalary > personTwoSalary));
            Console.ReadLine();
        }
    }
}
