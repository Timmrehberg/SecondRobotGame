using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project
{
    public class LoveRobot : Robot
    {
        public int lovelevel;
        public int numberofhugs;
        public int strength;
        public int health;


        public LoveRobot(string Name, int BatteryLevel, int Weight, int Speed, int LoveLevel, int numberOfHugs, int Strength)
        {
            name = Name;
            batterylevel = BatteryLevel;
            weight = Weight;
            speed = Speed;
            lovelevel = LoveLevel;
            numberofhugs = numberOfHugs;
            strength = Strength;
            health = 100;

        }



    }
}
