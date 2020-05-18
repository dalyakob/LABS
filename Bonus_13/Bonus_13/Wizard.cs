using System;

namespace Bonus_13
{
    public class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }

        public Wizard(string name, int strength, int intelligence) : base(name, strength, intelligence)
        {
            Name = "Wizzard - " + name;
            Strength = strength;
            Intelligence = 100;
            MagicalEnergy = 90;
            SpellNumber = 70;

        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Spell Number: {SpellNumber}");
        }
        public override void move(int x, int y)
        {

        }
    }
}