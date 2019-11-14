using System;
//similar to your imports in JS now have access to every class in namespace

namespace Intro
//name space is sorta like a module. helps us create module code. 
{
    class Program
    //
    {
        static void Main(string[] args)
        //main= method... methods are fxns. void is important. need to now specify what type of things your methods return. void indicates that we dont return anything
        {
            //declaring and assigning variable
            string name = "Adam";
            int cohort = 34;

            //cannot say name = 5 bc we already told the compiler what type it is 

            //referencing variable and reassigning it. don't need string infront of it bc already declared that above 
            name = "Jisie";
            cohort = 35;

            //string concat
            string greeting = "Hello " + name + ". Welcome to cohort " + cohort;

            //string interpolation. in JS we do this w/ backticks 
            //new variable called greeting2
            string greeting2 = $"Hello {name}. Welcome to Cohort {cohort}";

            //declare variable 
            bool isTheBest = cohort == 35;

            //conditionals

            if (isTheBest)
            {
                Console.WriteLine("Ah,, the best around");
            }
            else if (name == "Jisie")
            {
                Console.WriteLine("Well not in the right cohort. but shes still cool");

            }
            else
            {
                Console.WriteLine("you may... want to rethink your decisions");
            }

            //loops before we loop over anything we need something to loop over 
            //type is going to be an array. what is the type of thing that array holds?

            int[] cohorts = new int[] { 34, 35, 36, 37 };

            for (int i = 0; i < cohorts.Length; i++)
            {
                Console.WriteLine($"Cohort {cohorts[i]}");
            }

            //For each loops 
            //if iterating over each type its called int 
            //item could be taco so change it to c
            foreach (int c in cohorts)
            {
                Console.WriteLine($"Cohort {c}");
            }

            //while loops
            //w/o the break it would have run forever 
            while (cohort > 0)
            {
                cohort--;
                Console.WriteLine(cohort);
            }

            // Console.WriteLine(greeting2);
        }
    }
}