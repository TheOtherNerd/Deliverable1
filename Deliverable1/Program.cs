using System;

namespace Deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool realInt = false;
            int requestedNum = 0;
            //ask number of sandwiches
            Console.WriteLine("How many sandwiches are we making?");
            string sandwichNumber = Console.ReadLine();
            realInt = int.TryParse(sandwichNumber, out requestedNum);

            //find number of loaves
            double totalSlicesNeeded = requestedNum * 2;
            double totalLoavesNeeded = Math.Ceiling(totalSlicesNeeded / 28);
            
            //var totalLoaves = Math.Round(totalLoavesNeeded, 0);

            //do the same for the jars
            double totalPBSpoons=requestedNum * 2;
            double totalPBJars = Math.Ceiling(totalPBSpoons / 32);
            

            double totalJSpoons=requestedNum*4;
            double totalJJars =Math.Ceiling(totalJSpoons / 48);
            

            //calc amount of slices tablespoons of PB and teaspoons of J
            //1 sandwich = 2 slices, 2 TBS of PB, 4 TS of J
            //1 loaf = 24 slices
            //1 PB jar = 32 TBS
            //1 J jar = 48 TS

            //Console.WriteLine("Sandwiches made: " + realInt);
            Console.WriteLine("Total slices needed: "+totalSlicesNeeded);
            Console.WriteLine("Total peanut butter tablespoons needed: " + totalPBSpoons);
            Console.WriteLine("Total jelly teaspoons needed: " + totalJSpoons);
            Console.WriteLine("Which equates to...");
            Console.WriteLine("Total loaves needed: " + totalLoavesNeeded);
            Console.WriteLine("Total peanut butter jars needed: " + totalPBJars);
            Console.WriteLine("Total jelly jars needed: " + totalJJars);

            Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
            string userResponse = Console.ReadLine();
            if (userResponse == "yes" || userResponse == "y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye");
                Console.ReadLine();
            }
        }   
    }       
}
