using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorldProjekt
{
    public class World
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Cell[,] Cells { get; set; }

        public World(int width, int height)
        {
            Width = width;
            Height = height;
            Cells = new Cell[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Cells[x, y] = new Cell(x, y);
                }
            }
        }

        public Cell GetCell(int x, int y)
        {
            return Cells[x, y];
        }

        public void AddCreature(Creature creature, int x, int y)
        {
            Cells[x, y].AddCreature(creature);
            creature.CurrentCell = Cells[x, y];
        }

        public void AddPlant(Plant plant, int x, int y)
        {
            Cells[x, y].AddPlant(plant);
        }

        public void RemoveCreature(Creature creature)
        {
            creature.CurrentCell.RemoveCreature(creature);
        }

        public List<Cell> GetNeighbors(Cell cell)
        {
            var neighbors = new List<Cell>();

            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    int nx = cell.X + dx;
                    int ny = cell.Y + dy;
                    if (nx >= 0 && nx < Width && ny >= 0 && ny < Height && (dx != 0 || dy != 0))
                    {
                        neighbors.Add(Cells[nx, ny]);
                    }
                }
            }
            return neighbors;
        }

        public void Update()
        {
            foreach (var cell in Cells)
            {
                cell.Update();
            }
        }
    }

}
