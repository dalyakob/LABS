using System;

namespace Bonus_13
{
    internal class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }

        public Wizard(string name, int strength, int magicalEnergy)
        {
            Name = "Wizzard - " + name;
            Strength = strength;
            Intelligence = 100;
            MagicalEnergy = magicalEnergy;
            SpellNumber = 70;

        }
        public override void Play()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
            Console.WriteLine($"Spell Number: {SpellNumber}");
        }
    }
}