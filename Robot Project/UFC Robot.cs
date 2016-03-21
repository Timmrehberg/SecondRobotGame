using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project
{
    class UFC_Robot : FightingRobots
    {
     public   int health;
      
        public UFC_Robot(string Name,int Strength, int Power )
        {
            name = Name;
            strength = Strength;
            power = Power;
            health = 100;
        }
        public int Aimforthehead()
        {
            health -= 35;
            return health;
        }
        public int Grapple()
        {
            health -= 40;
            return health;
        }
        public int Submission()
        {
            health -= 50;
            return health;
                 
        }
        public int Ripoffarms()
        {
            health -= 100;
            return health;
        }
        public int Choke()
        {
            health -= 100;
            return health;
        }

    }
}
