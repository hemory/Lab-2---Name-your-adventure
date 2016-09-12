using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Program
    {
        static string b;
        static string c;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("What is your name my furry little friend you?");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome" + " " + userName);


            Console.WriteLine("Would you like to play a game? (y/n)");
            b = Console.ReadLine();

            if (b == "y")
            {
                Console.WriteLine("Excellent! \n\n You are walking a cross a field and you encounter a fire breathing dragon!");


                {
                    Console.WriteLine("What would you do?");
                    Console.WriteLine("Enter FACE THE BEAST or RUN AWAY");
                    c = Console.ReadLine();

                    if (c == "face the beast")
                    {
                        string headOption;
                        do
                        {
                            Console.WriteLine("You approach the dragon \n\n You see that he has...");
                            Console.WriteLine("enter 1 or 2 or 3");
                            headOption = Console.ReadLine();

                        } while (!(headOption == "1" || headOption == "2" || headOption == "3"));

                        switch (headOption)
                        {
                            case "1":
                                Console.WriteLine("Not very adventurous are we? \n Enters a one headed dragon.");
                                break;
                            case "2":
                                Console.WriteLine("Oh snap! A two headed dragon enters the room!");
                                break;
                            case "3":
                                Console.WriteLine("Some one has a Napolean complex I see!");
                                break;
                            default:
                                Console.WriteLine("You had one job. \n Pick a number. \n You have failed and the dragon has eaten you based on your stupidity");
                                return;

                        }

                        Console.WriteLine("Choose bow or sword or slingshot");
                        string differentWeapons = Console.ReadLine();


                        switch (differentWeapons)
                        {
                            case "bow":
                                Console.WriteLine("Equipped with your handy bow you approach the dragon.");
                                break;
                            case "sword":
                                Console.WriteLine("Equipped with your handy sword you approach the dragon.");
                                break;
                            case "slingshot":
                                Console.WriteLine("Equipped with your handy slingshot you approach the dragon.");
                                break;
                            default:
                                Console.WriteLine("That's not a great choice... The dragon eats you");
                                return;
                        }

                        Console.WriteLine("You can feel the hotness of his breath as you draw near. \n\n It stares at you with his ___ eyes \n\n Choose red or blue.");
                        string eyeColor = Console.ReadLine();

                        switch (eyeColor)
                        {
                            case "red":
                                Console.WriteLine("Oh man, you got lucky. Red -Eyed dragon are friendly. You rub its back and become friends. Press ANY KEY to continue.");
                                break;
                            case "blue":
                                Console.WriteLine("Oh man, you got lucky. Blue -Eyed dragon are friendly. You rub its back and become friends. Press ANY KEY to continue.");
                                break;
                            default:
                                Console.WriteLine("I'm just going to assume you didn't learn how to read directions and let you be");
                                break;

                        }

                        Console.ReadKey();
                        Console.WriteLine("You name the Dragon");
                        string nameDragon = Console.ReadLine();
                        Console.WriteLine("You and" + " " + nameDragon + " " + "live happily ever after");
                        Console.WriteLine("Thanks for playing.");

                        Console.ReadKey();
                    }
                    if (c == "run away")
                    {
                        Console.WriteLine("Thank you for playing.");
                    }
                }
                if (b == "n")
                {
                    Console.WriteLine("Thank you for playing.");
                }
            }
        }
    }
}