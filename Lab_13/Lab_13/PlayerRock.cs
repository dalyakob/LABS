using Lab_13.Properties;

namespace Lab_13
{
    public class PlayerRock : Player
    {
        public PlayerRock()
        {
            Name = "Player Rock";
            Roshambo = GenerateRoshambo();
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}