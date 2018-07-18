using System;

namespace Lab3
{
    class MainClass
    {
        public static void Main()
        {
            double i;

            Console.WriteLine("Please enter a whole integer between 1 and 100: ");
            i = Double.Parse(Console.ReadLine());

            //like jesse's code you can knock out if your number is in the range by
            //if (i 1 >= || i <= 100) that will let you move forward if true
            //then eval for if odd the should move right to Continue() validation
            //input
            if (i % 2 == 0 && i >= 2 && i <= 25)
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
            /* not needed because it's evaluated if odd
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

            Continue();

            //processing if statements and nested if statements based on 5 conditions
            //output
        }

        //Create a new method that refers to the Main at the top outside the Main method (HAD to delete the string [] args)
        //validation from two prompt options
        static void Continue()
        {
            Console.WriteLine("Would you like to continue? Type Y/N.");
            if (Console.ReadLine() == "Y")
            {
                Main();
            }
            else
            {
                return;
            }
           //TO DO create if the user puts in non integer values USE Try Catch validation. also evaluate if the user puts in different Y/N for the last prompt to Continue()
        }
    }
}






