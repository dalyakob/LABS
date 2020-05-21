using System;
using Lab_13.Properties;

namespace Lab_13
{
    public class PlayerRandom : Player
    {
        public PlayerRandom()
        {
            Name = "Player Random";
            Roshambo = GenerateRoshambo();
        }

        public override Roshambo GenerateRoshambo()
        {
            var random = new Random();

            return (Roshambo)random.Next(0, 3); 
        }
    }
}