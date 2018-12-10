using System;

namespace CombatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World(100, 400);

            Skirmish skirmish = new Skirmish(world.humans, world.zombies);
            skirmish.ExecuteSkirmish();

            Console.WriteLine("Humans: " + world.humans.Count);
            Console.WriteLine("Zombies: " + world.zombies.Count);
            Console.WriteLine("Combat took " + skirmish.Turns + " turns to complete!");

            Console.ReadKey();
        }
    }
}
