using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project
{
    class BruceLeeRobot : FightingRobots
    {
        public int health;



        public BruceLeeRobot(string Name, int Strength, int Power )
        {
            name = Name;
            strength = Strength;
            power = Power;
            health = 100;
        }
        public int Headattack()
        {
            health -= 30;
            return health;
        }
        public int FlyingKick()
        {
            health -= 50;
            return health;
        }
        public int Ripheartout()
        {
            health -= 100;
            return health;
        }
        public int Ripoffhead()
        {
            health -= 100;
            return health;
        }

    }
}
