using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorldProjekt
{
    public class Plant
    {
        public int GrowthLevel { get; set; }
        public bool IsFullyGrown => GrowthLevel >= 5;

        public void Grow()
        {
            if (GrowthLevel < 5)
            {
                GrowthLevel++;
            }
        }

        public void Spread(World world)
        {
            if (IsFullyGrown)
            {
            }
        }

        public void GetEaten()
        {
            GrowthLevel = 0; 
        }
    }

}
