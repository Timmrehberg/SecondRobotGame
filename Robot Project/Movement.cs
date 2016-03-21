using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project
{
    public class Movement : Robot
    {

        public void robotRace()
        {
            FastRobot Mcqueen = new FastRobot("Mcqueen", 100, 25, 120);
            HeavyRobot Albert = new HeavyRobot("Albert", 100, 85, 15);
            MysteryMachine Bruce = new MysteryMachine("Scooby-Doo", 100, 40,5000, 25);
            List<FastRobot> speedbots = new List<FastRobot>();
            List<HeavyRobot> fat = new List<HeavyRobot>();
            List<MysteryMachine> asian = new List<MysteryMachine>();
            speedbots.Add(Mcqueen);
            fat.Add(Albert);
            asian.Add(Bruce);
            foreach (FastRobot speedy in speedbots) {
                foreach (HeavyRobot heavy in fat) {
                    foreach (MysteryMachine badass in asian) {
                        Console.WriteLine("What robots would you like to race?: Fast Robot and Heavy Robot or Fast Robot and Scooby-Doo Robot(Case Sensitive)");
                        string choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "Fast Robot and Heavy Robot":
                                if (speedy.speed > heavy.speed)
                                {
                                    Console.WriteLine(speedy.name + " " + "Wins!");

                                }
                                break;
                            case "Fast Robot and Scooby-Doo Robot":
                                Console.WriteLine("Nobody beats " + badass.name);
                                break;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }

                    }
                }
            }
        }
    }
}