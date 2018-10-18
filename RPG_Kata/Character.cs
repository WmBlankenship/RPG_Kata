using System;

namespace RPG_Kata
{
    public class Character
    {
        private const int HEALTH_INCREMENT_FROM_HEAL = 50;
        private const int HEALTH_DECREMENT_FROM_ATTACK = 40;

        public double Health { get; set; }
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

            damagedCharacter.Health -= HEALTH_DECREMENT_FROM_ATTACK * GetDamageMultiplier(damagedCharacter.Level);

            if (damagedCharacter.Health < 0)
            {
                KillCharacter(damagedCharacter);
            }
        }

        public void Heal()
        {
            this.Health += HEALTH_INCREMENT_FROM_HEAL;

            if (this.Health > 1000)
            {
                this.Health = 1000;
            }
        }

        private void KillCharacter(Character soonToBeDeadCharacter)
        {
            soonToBeDeadCharacter.Health = 0;
            soonToBeDeadCharacter.Alive = false;
        }

        private double GetDamageMultiplier(int level)
        {
            if (this.Level >= level + 5) return 1.5;

            if (this.Level + 5 <= level) return .5;

            return 1;
        }
    }
}
