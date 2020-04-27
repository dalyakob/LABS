using System;

namespace Lab_6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to David's Dice roller appilication!\n");

            do
            {
                //gets number of sides from method 
                var sides = GetSides();

                //Displays dice rolled 
                Console.WriteLine("\nDie Rolled: " + RollDice(sides) + " & " + RollDice(sides));

                //asks for user input to change loop condition
                Console.WriteLine("\nWould you like to roll the die again? (y/n)");
            } while (Console.ReadLine().ToLower() == "y");

        }

        //asks user for number of sides and loops if an exception was thrown
        public static int GetSides()
        {
            bool valid;
            int sides;
            do
            {
                Console.WriteLine("What size dice would you like to roll?");
                valid = int.TryParse(Console.ReadLine(), out sides);
                if (!valid)
                    Console.WriteLine("Invalid integer, please try again!");
            } while (!valid);
            return sides;
        }

        //Roles dice once with given number of sides
        public static int RollDice(int sides)
        {
            var random = new Random();
            return random.Next(sides)+1;
        }
    }
}
