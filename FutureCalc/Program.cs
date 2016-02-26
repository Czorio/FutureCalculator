using System;

namespace FutureCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            DateTime newDate;

            Console.Out.WriteLine("Put in the amount of milliseconds you wish to get the future date from");
            string input = Console.In.ReadLine();

            // try to parse the input string, int.tryparse returns a true if successful, so it can be easily used in the if/else block
            double parsedString;
            if (double.TryParse(input, out parsedString))
            {
                newDate = currentDate.AddMilliseconds(parsedString);
            }
            else
            {
                // yell at the user and exit
                Console.Out.WriteLine("Faulty input, please restart and input a number.");
                Console.Out.WriteLine("Press enter to exit...");
                Console.In.ReadLine();
                return;
            }

            Console.Out.WriteLine(newDate);

            Console.Out.WriteLine("Press enter to exit...");
            Console.In.ReadLine();
        }
    }
}
