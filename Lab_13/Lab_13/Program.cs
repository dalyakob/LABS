using System;
using Lab_13.Properties;

namespace Lab_13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");

            var playGame = new RoshamboApp();
            int wins = 0, loss = 0, draw = 0, temp;

            var player = new PlayerChoice();
            
            do
            {
                temp = playGame.PlayGame(player);

                if(temp == 1)
                    wins++;
                else if(temp == 2)
                    loss++;
                else
                    draw++;

                Console.WriteLine($"\nWins: {wins} \nLosses: {loss} \nDraws: {draw}");

                Console.WriteLine("\nPlay again?");
            } while (Console.ReadLine() == "y");

            Console.WriteLine("\nThanks for playing!!!");
        }
    }
}
