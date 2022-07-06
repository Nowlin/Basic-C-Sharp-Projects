using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Methods_Assignment_1
{
    public class CMAClass
    {
        public int Add(int numOne)
        {
            int Sum = (numOne + 5);
            return Sum;
        }
        public decimal Deci(decimal numTwo)
        {
            int Multi = Convert.ToInt32(numTwo * 3);
            return Multi;
        }
        public int String(string numThree)
        {
            int Divide = Convert.ToInt32(numThree);
            int DivideTwo = (Divide / 2);
            return DivideTwo;
        }
    }
}
