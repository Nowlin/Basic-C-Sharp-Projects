using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Method_Assignment
{
    public class CMA
    {
        public void Divide(int divide)
        {
            int answer = (divide / 2);
            Console.WriteLine(answer);
        }
        public int Divide(int times, int add, int subtract)
        {
            int Yo = (times * 5);
            int Dis = (add + 3);
            int Ard = (subtract - 11);
            return Yo + Dis + Ard;
        }
        public static string NahBru(out string nahBru, out string nahBruh)
        {
            nahBru = "hello";
            nahBruh = " world";
            return nahBru + nahBruh;
        }
    }
    public static class CMAdude
    {

    }
}
