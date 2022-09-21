using System;
using System.Runtime.CompilerServices;

class MainClass
{
   

    public static void Main()
    {
        bool a = true;
        while (a == true)
        {
            MakeSandwiches();
            // looping the program
            Console.WriteLine("Would you like to make more sandwiches?");
            string repeat = Console.ReadLine();
            if (repeat == "yes")
            {
                Console.WriteLine("Awesome, lets make more sandwiches!");
                continue;
            }
            else if (repeat == "y")
            {
                Console.WriteLine("You must really want sandwiches. Lets make some more ;) !");
                continue;
            }
            else
            {
                Console.WriteLine("Goodbye");
                a = false;
            }
        }

    }

    public static void MakeSandwiches()
    {
        Console.WriteLine("How many people are we making Peanut Butter and Jelly Sandwiches for?");
        int answer = int.Parse(Console.ReadLine());

        // Building the criteria of the food
        int slices = answer * 2;
        int tablespoonpeanut = answer * 2;
        int teaspoonjelly = answer * 4;
        // complex criteria of food
        float loaves = slices / 28f;
        float pbjars = tablespoonpeanut / 32f;
        float jellyjars = teaspoonjelly / 48f;
        //displaying text finalizing the amount of food needed
        Console.WriteLine("Since you are making Peanut Butter and Jelly Sandwiches for " + answer + " people, you will need:");
        Console.WriteLine("     " + slices + " slices of bread");
        Console.WriteLine("     " + tablespoonpeanut + " table spoons of peanut butter");
        Console.WriteLine("     " + teaspoonjelly + " teaspoons of jelly");
        Console.WriteLine(" Which is....");
        Console.WriteLine("     " + Math.Ceiling(loaves) + " loaves of bread");
        Console.WriteLine("     " + Math.Ceiling(pbjars) + " jars of peanut butter");
        Console.WriteLine("     " + Math.Ceiling(jellyjars) + " jars of jelly");
    }
}

