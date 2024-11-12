using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheWorldProjekt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            World world = new World(10, 10);

            world.AddPlant(new Plant(), 3, 3);
            world.AddCreature(new Herbivore(20, 3, 1), 5, 5);
            world.AddCreature(new Carnivore(30, 4, 2), 2, 2);

            for (int i = 0; i < 100; i++)
            {
                Console.Clear();
                Console.WriteLine($"Szimuláció lépés: {i + 1}");

                world.Update();

                DisplayWorld(world);

                Thread.Sleep(500);
            }
        }

        public static void DisplayWorld(World world)
        {
            for (int x = 0; x < world.Width; x++)
            {
                for (int y = 0; y < world.Height; y++)
                {
                    Cell cell = world.GetCell(x, y);

                    if (cell.Plant != null)
                        Console.Write("P ");  
                    else if (cell.Inhabitants.Count > 0)
                    {
                        if (cell.Inhabitants[0] is Herbivore)
                            Console.Write("H ");  
                        else if (cell.Inhabitants[0] is Carnivore)
                            Console.Write("C ");  
                    }
                    else
                        Console.Write(". "); 
                }
                Console.WriteLine();
            }
        }
    }
}
