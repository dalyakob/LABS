using System;

namespace Bonus_13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Object Array of GameCharacters
            var gameCharacter = new GameCharacter[] {new Warrior("dumb", 95, 23, "Sword"),
                                                     new Warrior("dumber", 12, 23, "Axe"),
                                                     new Wizard("Some Dude", 30, 150),
                                                     new Wizard("David", 999, 999),
                                                     new Wizard("Jason", 998, 997)};

           //Loops through all characters in the array and runs their play method 
            foreach (var character in gameCharacter)
            {
                character.Play();
                Console.WriteLine();
            }
        }
    }
}
