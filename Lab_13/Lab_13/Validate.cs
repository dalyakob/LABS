using System;
namespace Lab_13.Properties
{
    public class Validate
    {
        public Validate()
        {
        }

        public string PlayerVS()
        {
            string input;
            do
            {
                Console.WriteLine("Who would you like to play against?\n" +
                                  "(1)Player Rock - Roshambo Value = Rock\n" +
                                  "(2)Player Random - Roshambo Value = Random");
                input = Console.ReadLine();
            } while (!(input == "1" || input == "2"));

            return input;
        }
        public string RPS()
        {
            string input;
            do
            {
                System.Console.WriteLine("Rock, Paper, or Scissors? (R/P/S)");
                input = System.Console.ReadLine().ToUpper();
            } while (!(input == "R" || input == "P" || input == "S"));
            return input;
        }
    }
}
