using System;

namespace Lab3
{
    class MainClass
    {
        public static void Main(string[] args)
        { 
            double i;

            Console.WriteLine("Please enter a whole integer between 1 and 100: ");
            i = Double.Parse(Console.ReadLine());

            //input
            if (i % 2 == 0 && i >= 2 && i <=25)
            {
                Console.WriteLine("Your number is Even and less than 25!");
                Console.ReadLine();
            }
            else if (i % 2 == 0 && i >= 26 && i <= 60)
            {
                Console.WriteLine("Your number is Even!");
                Console.ReadLine();
            }
            else if (i % 2 == 0 && i > 60)
            {
                Console.WriteLine($"{i}; Your number is Even!");
                Console.ReadLine();
            }
            /* not needed
            else if (i % 2 == 1 && i > 60)
            {
                Console.Write("Your number is Odd!");
                Console.ReadLine();
            }*/
            else if (i % 2 == 1)
            {
                Console.Write($"{i}; Your number is Odd!");
                Console.ReadLine();
            }

            //processing if statements and nested if statements based on 5 conditions
            //output

        }
    }
}
