using System;

namespace Bonus_13
{
    internal class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public Warrior(string name, int strength, int intelligence, string weaponType): base(name, strength, intelligence)
        {
            Name = "Warrior - " + name;
            Strength = strength;
            Intelligence = intelligence;
            WeaponType = weaponType;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Weapon Type: {WeaponType}");
        }

        public override void move(int x, int y)
        {

        }
    }
}