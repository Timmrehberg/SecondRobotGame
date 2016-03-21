using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project
{
  class Program
    {
        static void Main(string[] args)
        {         
            Movement race = new Movement();
            race.robotRace();
            FightClub fighting = new FightClub();
            fighting.FightTime();

        }
    }
}
