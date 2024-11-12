using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorldProjekt
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public List<Creature> Inhabitants { get; set; }
        public Plant Plant { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            Inhabitants = new List<Creature>();
        }

        public void AddCreature(Creature creature)
        {
            Inhabitants.Add(creature);
        }

        public void RemoveCreature(Creature creature)
        {
            Inhabitants.Remove(creature);
        }

        public void AddPlant(Plant plant)
        {
            Plant = plant;
        }

        public void Update()
        {
            Plant?.Grow();
        }
    }

}
