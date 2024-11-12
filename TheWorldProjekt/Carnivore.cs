using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorldProjekt
{
    public class Carnivore : Creature
    {
        public int Size { get; set; }

        public Carnivore(int energy, int sightRange, int size) : base(energy, sightRange)
        {
            Size = size;
        }

        public Cell FindBestCellToMove()
        {
            return null;
        }

        public void EatCreature(Creature other)
        {
            if (other != null && other.IsAlive())
            {
                other.Energy = 0; 
                Energy += 20;
            }
        }

        public override void Move(Cell newCell)
        {
            CurrentCell.RemoveCreature(this);
            newCell.AddCreature(this);
            CurrentCell = newCell;
        }

        public override void Eat(Creature other)
        {
            EatCreature(other);
        }
    }

}
