using System;

namespace RPG_Kata
{
    public class Character
    {
        public int Health { get; private set; }
        public int Level { get; set; }

        public Character()
        {
            this.Health = 1000;
            this.Level = 1;
        }
    }
}
