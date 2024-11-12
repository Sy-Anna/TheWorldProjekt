using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorldProjekt
{
    public class Herbivore : Creature
    {
        public int Size { get; set; }

        public Herbivore(int energy, int sightRange, int size) : base(energy, sightRange)
        {
            Size = size;
        }

        public Cell FindBestCellToMove()
        {
            return null;
        }

        public void EatPlant()
        {
            if (CurrentCell.Plant != null)
            {
                CurrentCell.Plant.GetEaten();
                Energy += 10; 
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

        }
    }

}
