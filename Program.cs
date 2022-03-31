using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your result:");
            char Input = Convert.ToChar(Console.ReadLine().ToUpper());

            if (Input == 'A')
            {
                Console.WriteLine("Outstanding!");
            } else if (Input == 'B')
            {
                Console.WriteLine("Superior!");
            } else if (Input == 'C')
            {
                Console.WriteLine("Good!");
            } else if (Input == 'D')
            {
                Console.WriteLine("Satisfactory!");
            } else if (Input == 'E')
            {
                Console.WriteLine("Low Pass!");
            } else if (Input == 'F')
            {
                Console.WriteLine("Failure!");
            } else
            {
                Console.WriteLine("Result is invalid!");
            }
        }
    }
}
