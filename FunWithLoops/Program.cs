using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach loops
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            foreach (string month in months)    //the variable month only exists for this loop
            {
                Console.WriteLine(month);
                if(month =="Dec")
                {
                    Console.WriteLine("That's the best month!");
                }
                else
                {
                    Console.WriteLine("That month is okay, I guess.");
                }
            }
            string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "Nas", "Jarryd" };
            foreach(string band in musicians)
            {
                Console.WriteLine(band);
            }

            //create a progran that asks the user for their favorite food and stores that value in an array
            //loop through the array and print all of the foods -- 3x
            string[] faveFoods = new string[3];
            Console.WriteLine("What is your most favorite food?");
            faveFoods[0] = Console.ReadLine();
            Console.WriteLine("What is your second favorite food?");
            faveFoods[1] = Console.ReadLine();
            Console.WriteLine("What is your third favorite food?");
            faveFoods[2] = Console.ReadLine();
            foreach(string food in faveFoods)
            {
                Console.WriteLine(food);
            }

            //create an array of lucky numbers using a foreach loop print the following:
            //your lucky number is: 4
            //your lucky number is: 4
            //your lucky number is: 4
            int[] luckyNumbers = { 2, 4, 24 };
            foreach(int number in luckyNumbers)
            {
                Console.WriteLine("Your lucky number is "+number);
            }

        }
    }
}
