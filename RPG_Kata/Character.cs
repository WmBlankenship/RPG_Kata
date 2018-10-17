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

        public void Attack(Character damagedCharacter)
        {
            if (damagedCharacter == this) return;

            damagedCharacter.Health -= 50;

            if (damagedCharacter.Health < 0)
            {
                damagedCharacter.Alive = false;
                damagedCharacter.Health = 0;
            }
        }

        public void Heal()
        {
            this.Health += 50;

            if (this.Health > 1000)
            {
                this.Health = 1000;
            }
        }
    }
}
