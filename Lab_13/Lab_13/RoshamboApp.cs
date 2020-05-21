using System;
using Lab_13.Properties;

namespace Lab_13
{
    public class RoshamboApp
    {
        public RoshamboApp()
        {

        }
        public int PlayGame(PlayerChoice playerChoice)
        {

            var playerClass = new Validate().PlayerVS();

            playerChoice.GenerateRoshambo();

            Console.WriteLine($"You picked: {playerChoice.Roshambo}" );

            if(playerClass == "1")
            {
                //var playerRock = new PlayerRock();
                Console.WriteLine($"AI picked: {Roshambo.Rock}\n");

                if (playerChoice.Roshambo == Roshambo.Rock)
                {
                    Console.WriteLine("Draw!!!");
                    return 0;
                }
                else if(playerChoice.Roshambo == Roshambo.Paper)
                {
                    Console.WriteLine("YOU WIN!!!");
                    return 1;
                }
                else
                {
                    Console.WriteLine("You suck!!!");
                    return 2;
                }


            }
            else
            {
                var playerRandom = new PlayerRandom();
                Console.WriteLine($"AI picked: {playerRandom.Roshambo}\n");
                if (playerChoice.Roshambo == Roshambo.Rock)
                {
                    if(playerRandom.Roshambo == Roshambo.Rock)
                    {
                        Console.WriteLine("Draw");
                        return 0;
                    }
                    else if(playerRandom.Roshambo == Roshambo.Paper)
                    {
                        Console.WriteLine("You suck!!!");
                        return 2;
                    }
                    else
                    {
                        Console.WriteLine("YOU WIN!!!");
                        return 1;
                    }
                }
                else if (playerChoice.Roshambo == Roshambo.Paper)
                {
                    if (playerRandom.Roshambo == Roshambo.Paper)
                    {
                        Console.WriteLine("Draw");
                        return 0;
                    }
                    else if (playerRandom.Roshambo == Roshambo.Scissors)
                    {
                        Console.WriteLine("You suck!!!");
                        return 2;
                    }
                    else
                    {
                        Console.WriteLine("YOU WIN!!!");
                        return 1;
                    }
                }
                else if (playerChoice.Roshambo == Roshambo.Scissors)
                {
                    if (playerRandom.Roshambo == Roshambo.Scissors)
                    {
                        Console.WriteLine("Draw");
                        return 0;
                    }
                    else if (playerRandom.Roshambo == Roshambo.Rock)
                    {
                        Console.WriteLine("You suck!!!");
                        return 2;
                    }
                    else
                    {
                        Console.WriteLine("YOU WIN!!!");
                        return 1;
                    }
                }
                return -1;
            }

        }

    }
}

