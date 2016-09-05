using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FitnessFrogApp
{
    class Program
    {
        static void Main()
        {
            var runningTotal = 0.0;

            while (true)
            {
                //prompt the user for minutes exercised
                System.Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");

                var entry = System.Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }

                try
                {
                    var minutes = double.Parse(entry);
                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is not an acceptable value");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go hot stuff!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("You must be training for Ninja Warrior");
                    }
                    else
                    {
                        Console.WriteLine("Ok now you're just showing off!");
                    }
                    //add minutes exercised to total
                    runningTotal += minutes;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not valid input");
                    continue;
                }


                //display total minutes exercised to the screen
                System.Console.WriteLine("You've exercised " + runningTotal + " minutes");
            }
        
        //repeat until the user quits
        Console.WriteLine("Goodbye!");
          }
        }
    }


