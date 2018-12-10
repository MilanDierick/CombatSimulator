using System.Collections.Generic;

namespace CombatSimulator
{
    public class World
    {
        public List<Entity> humans;
        public List<Entity> zombies;

        public World()
        {
            humans = new List<Entity>();
            zombies = new List<Entity>();
        }

        public World(int humansCount, int zombiesCount)
        {
            humans = new List<Entity>();
            zombies = new List<Entity>();

            for (int i = 0; i < humansCount; i++)
            {
                humans.Add(new Entity(100, 50, true, 0.8f, 0.5f, 0.6f));
            }

            for (int i = 0; i < zombiesCount; i++)
            {
                zombies.Add(new Entity(50, 45, true, 0.25f, 0.1f, 0.4f));
            }
        }
    }
}