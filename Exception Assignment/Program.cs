using System;

namespace Exception_Assignment
{
    class Program
    {
        static void Main()
        {
            try
            {
                int[] oneArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
                Console.WriteLine("Please choose a number to be divided by a list of created numbers");
                int alphaNum = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < oneArray.Length; i++)
                {
                    int listDivInp = oneArray[i] / alphaNum;
                    Console.WriteLine(listDivInp);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please only use integers, examples: 1, 35, 8, 200, ... Thanks.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero....");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
