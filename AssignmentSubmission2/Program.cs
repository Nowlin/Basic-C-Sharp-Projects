using System;

namespace AssignmentSubmission2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you in?");
            string courseOn = Console.ReadLine();

            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you\'d like to share? Please give specifics.");
            string posExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you\'d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
        }
    }
}
