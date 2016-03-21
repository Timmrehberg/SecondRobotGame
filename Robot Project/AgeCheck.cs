using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project
{
    class AgeCheck
    {
        public int checkingage()
        {
            
            Console.WriteLine("How old are you?");
           int AgeCheck = Convert.ToInt32(Console.ReadLine());
            if(AgeCheck < 18)
            {
                Console.WriteLine("Sorry you are too young to play this game");
                throw new ArgumentOutOfRangeException();


            } else if(AgeCheck >= 18)
            {
                Console.WriteLine("Welcome to my game");
            }
            return AgeCheck;
        }

    }
}
