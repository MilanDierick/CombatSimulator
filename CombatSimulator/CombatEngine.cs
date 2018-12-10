using System;

namespace CombatSimulator
{
    public static class CombatEngine
    {
        private static readonly Random random = new Random();

        public static void Fight(Entity attacker, Entity defender)
        {
            if (random.Next(0, 100) <= attacker.chanceToHit * 100)
            {
                if (random.Next(0, 100) <= defender.chanceToBlock * 100)
                {
                    defender.ReceiveDamage(attacker.damage);
                }
            }
        }
    }
}