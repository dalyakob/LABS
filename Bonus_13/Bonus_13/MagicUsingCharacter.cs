using System;

namespace Bonus_13
{
    public abstract class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public MagicUsingCharacter(string name, int strength, int intelligence) : base(name, strength, intelligence)
        {
            Name = "MagicUsingCharacter";
            Strength = 50;
            Intelligence = 80;
            MagicalEnergy = 70;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");

        }
    }
}