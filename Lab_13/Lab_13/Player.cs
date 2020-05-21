using System;
namespace Lab_13.Properties
{
    public abstract class Player
    {
        //public string LastName => Name;
        public string Name { get; set; }
        public Roshambo Roshambo { get; set; }
        
        public Player()
        {
            
        }

        public abstract Roshambo GenerateRoshambo();
    }
}
