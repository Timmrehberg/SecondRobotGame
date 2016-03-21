using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project
{
    class FightClub : FightingRobots
    {
        public void FightTime()
        {
            AgeCheck checking = new AgeCheck();
            BruceLeeRobot Bruce = new BruceLeeRobot("Bruce Lee", 90, 85);
            UFC_Robot Chuck = new UFC_Robot("Chuck Lidell", 100, 75);
            List<UFC_Robot> chuck = new List<UFC_Robot>();
            List<BruceLeeRobot> bruce = new List<BruceLeeRobot>();
            chuck.Add(Chuck);
            bruce.Add(Bruce);
            checking.checkingage();
            Console.WriteLine("Select your fighter: Bruce Lee or Chuck Liddell(Case Sensitive)");
            string pickfighter = Console.ReadLine();
            switch (pickfighter)
            {
                case "Bruce Lee":
                    Console.WriteLine("Head attack or Flying Kick");
                    string attack1 = Console.ReadLine();
                    if (attack1.Equals("Head attack"))
                    {
                        Bruce.Headattack();
                        Chuck.Aimforthehead();
                        Console.WriteLine("You punch Chuck in the head but not before he strikes you back with force");
                        Console.WriteLine("Your health is " + Chuck.health + " Chucks health is " + Bruce.health);
                    }

                    else if (attack1.Equals("Flying Kick"))
                    {
                        Bruce.FlyingKick();
                        Chuck.Grapple();
                        Console.WriteLine("Chuck grapples you but you escape");
                        Console.WriteLine("Your health is " + Chuck.health + " Chucks health is " + Bruce.health);
                    }
                    Console.WriteLine("Head attack or Flying Kick");
                    string attack2 = Console.ReadLine();
                    if (attack2.Equals("Head attack"))
                    {
                        Bruce.Headattack();
                        Console.WriteLine("You smash Chuck in the head dazing him but he still manages to strike you back");
                        Chuck.Aimforthehead();
                        Console.WriteLine("Your health is " + Chuck.health + " Chucks health is " + Bruce.health);
                        Console.WriteLine("Head attack or Flying Kick");
                        string attack4 = Console.ReadLine();
                        if (attack4.Equals("Head attack"))
                        {
                            Console.WriteLine("You miss and Chuck puts you in a unbreakable hold:Submit or Fight?");
                            string submitorcontinue = Console.ReadLine();
                            if (submitorcontinue.Equals("Submit"))
                            {
                                Console.WriteLine("You tap out and Chuck wins");

                            }
                            else if (submitorcontinue.Equals("Fight"))
                            {
                                Console.WriteLine("You try to fight out of it and exhaust your self and the ref saves your life");

                            }

                        }
                        if (attack4.Equals("Flying Kick"))
                        {
                            Console.WriteLine("You kick Chuck in the head so hard it makes him disabled:You Win!");
                        }
                    }
                    else if (attack2.Equals("Flying Kick"))
                    {
                        Bruce.FlyingKick();
                        Chuck.Aimforthehead();
                        Console.WriteLine("Chuck dazes you with a sharp jab to the head but is stunned with your swift kick (Finish Him!)");
                        Console.WriteLine("Rip off his head or Take out his heart!");
                        string attack3 = Console.ReadLine();
                        if (attack3.Equals("Rip off his head"))
                        {
                            Bruce.Ripoffhead();
                            Console.WriteLine("You rip off his head and shove it up his ass!:You Win!(Obviously)");
                        }
                        else if (attack3.Equals("Take out his heart"))
                        {
                            Bruce.Ripheartout();
                            Console.WriteLine("You rip out his heart and make him eat it!:You Win!");
                        }

                    }
                    break;
                case "Chuck Liddell":
                    Console.WriteLine("Grapple him and Jab or Jab ");
                   string Chucksfirstattack = Console.ReadLine();
                    if (Chucksfirstattack.Equals("Grapple him"))
                    {
                        Console.WriteLine("You take him to the ground and you both get in a few strikes");
                        Chuck.Grapple();
                        Bruce.Headattack();
                        Console.WriteLine("Your health is " + Bruce.health + " Bruce Lees health is " + Chuck.health);

                    }
                    else if (Chucksfirstattack.Equals("Jab"))
                    {
                        Console.WriteLine("You jab Bruce in the face and he returns a swift kick to your face");
                        Chuck.Aimforthehead();
                        Bruce.FlyingKick();
                        Console.WriteLine("Your health is " + Bruce.health + " Bruces health is " + Chuck.health);
                    }
                    Console.WriteLine("Grapple him and Jab or Jab");
                    string Chuckssecondattack = Console.ReadLine();
                    if (Chuckssecondattack.Equals("Grapple him"))
                    {
                        Console.WriteLine("You strike Bruce and try to grapple but he breaks out of it and dazes you with a flying kick");
                        Chuck.Aimforthehead();
                        Bruce.FlyingKick();
                        Console.WriteLine("Your health is " + Bruce.health + " Bruce Lees health is " + Chuck.health);
                    }
                    else if (Chuckssecondattack.Equals("Jab"))
                    {
                        Console.WriteLine("You get a clean jab on him and he misses his next attack");
                        Chuck.Aimforthehead();
                        Console.WriteLine("Your health is " + Bruce.health + " Bruce Lees health is " + Chuck.health);
                    }
                    Console.WriteLine("Grapple him and Jab or Jab");
                   string Chucksthirdattack = Console.ReadLine();
                    if(Chucksthirdattack.Equals("Grapple him"))
                    {
                        Chuck.Grapple();
                        Console.WriteLine("You take him down and and start beating in his face(Finish Him!)");
                        Console.WriteLine("Choke him or Rip his arms off");
                        string ChucksFinisher = Console.ReadLine();
                        if(ChucksFinisher.Equals("Choke him"))
                        {
                            Console.WriteLine("You Choke him until his eyes pop out of his head");

                        } else if(ChucksFinisher.Equals("Rip his arms off"))
                        {
                            Console.WriteLine("You rip off his arms and beat him with them");
                        }
                        
                        }
                    if (Chucksthirdattack.Equals("Jab"))
                    {
                        Console.WriteLine("You Jab him and miss and he does a flying kick and dazes you he taunts you to come at him: Go to him or Have him come to you");
                        string Tauntmove = Console.ReadLine();
                        if(Tauntmove.Equals("Go to him"))
                        {
                            Console.WriteLine("You approach him and he gives you a powerful roundhouse kick to the face and breaks your jaw: You Lose!");
                        } else if(Tauntmove.Equals("Have him come to you"))
                        {
                            Console.WriteLine("You wait and let him come to you and when he gets close you grapple him and take him to the ground");
                            Console.WriteLine("Beat him down or Submission Move?");
                            string ChucksDecision = Console.ReadLine();
                            if(ChucksDecision.Equals("Beat him down"))
                            {
                                Console.WriteLine("You keep the fist coming until he looks like Rocky(Yo Adriaan)");
                            } else if(ChucksDecision.Equals("Submission Move"))
                            {
                                Console.WriteLine("You give him the easy way out and choke him till hes forced to tapout:You Win!");
                            }
              

                        }

                    }
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;










            }











        }

    }
}







    

