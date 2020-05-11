using System;

namespace Bonus_13
{
    internal class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public Warrior(string name, int strength, string weaponType)
        {
            Name = "Warrior - " + name;
            Strength = strength;
            Intelligence = 60;
            WeaponType = weaponType;
        }

        public override void Play()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Weapon Type: {WeaponType}");
        }
    }
}