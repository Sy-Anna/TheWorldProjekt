using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorldProjekt
{
    public abstract class Creature
    {
        public int Energy { get; set; }
        public int SightRange { get; set; }
        public Cell CurrentCell { get; set; }

        public Creature(int energy, int sightRange)
        {
            Energy = energy;
            SightRange = sightRange;
        }

        public abstract void Move(Cell newCell);
        public abstract void Eat(Creature other);

        public bool IsAlive()
        {
            return Energy > 0;
        }
    }

}
