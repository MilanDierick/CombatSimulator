using System;
using System.Collections.Generic;

namespace CombatSimulator
{
    public class Skirmish
    {
        public int Turns;

        public List<Entity> Faction1Entities;
        public List<Entity> Faction2Entities;

        public Skirmish(List<Entity> faction1Entities, List<Entity> faction2Entities)
        {
            Turns = 0;
            Faction1Entities = faction1Entities;
            Faction2Entities = faction2Entities;
        }

        public void ExecuteSkirmish()
        {
            Random random = new Random();

            while (Faction1Entities.Count > 0 && Faction2Entities.Count > 0)
            {
                Entity attacker;
                Entity defender;

                if (Turns % 2 == 0)
                {
                    attacker = Faction1Entities.RandomElement();
                    defender = Faction2Entities.RandomElement();

                    CombatEngine.Fight(attacker, defender);

                    if (!attacker.isAlive)
                        Faction1Entities.Remove(attacker);
                    if (!defender.isAlive)
                        Faction2Entities.Remove(defender);
                }
                else
                {
                    attacker = Faction2Entities.RandomElement();
                    defender = Faction1Entities.RandomElement();

                    CombatEngine.Fight(attacker, defender);

                    if (!attacker.isAlive)
                        Faction2Entities.Remove(attacker);
                    if (!defender.isAlive)
                        Faction1Entities.Remove(defender);
                }

                Turns++;
            }
        }
    }
}