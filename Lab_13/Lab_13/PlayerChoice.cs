using Lab_13.Properties;

namespace Lab_13
{
    public class PlayerChoice : Player
    {
        public PlayerChoice()
        {
            Name = GetName();
        }

        private string GetName()
        {
            System.Console.Write("\nWhat is your name: ");
            return System.Console.ReadLine();
        }

        public override Roshambo GenerateRoshambo()
        {
            var input = new Validate().RPS();

            if(input == "R")
            {
                Roshambo = Roshambo.Rock;
                return Roshambo.Rock;
            }

            else if(input == "P")
            {
                Roshambo = Roshambo.Paper;
                return Roshambo.Paper;
            }
            else
            {
                Roshambo = Roshambo.Scissors;
                return Roshambo.Scissors;
            }

        }
    }
}