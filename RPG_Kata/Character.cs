using System;

namespace RPG_Kata
{
    public class Character
    {
        public int Health { get; set; }
        public int Level { get; set; }
        public bool Alive { get; set; }

        public Character()
        {
            this.Health = 1000;
            this.Level = 1;
            this.Alive = true;
        }
    }
}
