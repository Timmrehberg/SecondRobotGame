using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project
{
    public class HeavyRobot : Robot
    {

        public HeavyRobot(string Name, int BatteryLevel, int Weight, int Speed)
        {
            name = Name;
            batterylevel = BatteryLevel;
            weight = Weight;
            speed = Speed;
        }
    }
}
