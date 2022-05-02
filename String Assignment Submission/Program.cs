using System;
using System.Text;

namespace String_Assignment_Submission
{
    class Program
    {
        static void Main()
        {
            string textA = "This is a text, ";
            string textB = "that when combined, ";
            string textC = "forms a thought!";
            textC = textC.ToUpper();
            Console.WriteLine(textA + textB + textC);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("I am creating a paragraph that shows that I understand the use of \"StringBuilder\".");
            sb.Append("\nThis paragraph is hopefully going to prove that I somewhat understand the use of \"StringBuilder\"");
            sb.Append("\nC# part one is almost complete, and this is the last assignment I need to complete it... \nSo hopefully I am showing even just a basic understanding of it.");
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
