using System;

namespace Bonus_13
{
    internal class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public MagicUsingCharacter()
        {
            Name = "MagicUsingCharacter";
            Strength = 50;
            Intelligence = 80;
            MagicalEnergy = 70;
        }
        public override void Play()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");

        }
    }
}