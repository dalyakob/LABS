using System;

namespace Lab_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int userInput;
            string condition;

            Console.WriteLine("Hi welcome to our automated even or odd program!!\n");

            do
            {
                Console.WriteLine("Whats your fancy last name? ");
                var lastName = Console.ReadLine();

                Console.WriteLine("How may I refer to you (Mr/Mrs/Ms): ");
                var surname = Console.ReadLine();

                while(true)
                {
                    Console.WriteLine("Okay {0} {1}, enter an integer between 1 and 100: ", surname, lastName);
                    var valid = int.TryParse(Console.ReadLine(), out userInput);
                    if (valid && userInput <= 100 && userInput >= 0)
                        break;
                    else
                        Console.WriteLine("Invalid entry, please try again!");
                }  

                EvenOrOdd(userInput);

                Console.WriteLine("And last but not least would you like to continue {0} {1}? (y/n)", surname, lastName);
                condition = Console.ReadLine().ToLower();

            } while (condition == "y");
        }

        public static void EvenOrOdd(int userInput)
        {
            bool even = userInput % 2 == 0;

            if (!even) // Odd
            {
                Console.Write("{0} and odd ", userInput);
            }
            else if(userInput <= 25 && even)
            {
                Console.Write("Even and less than 25", userInput);
            }
            else if (userInput >= 26 && userInput <= 60 && even)
            {
                Console.WriteLine("Even");
            }
            else if (userInput > 60 && even)
            {
                Console.WriteLine("{0} and even", userInput);
            }

        }
    }
}
