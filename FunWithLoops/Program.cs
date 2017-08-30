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
            /*
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
            string[] names = { "Jordan", "Max", "Peter" };
            for(int i = 0; i< names.Length; i++)
            {
                names[i] = names[i].ToLower();
                Console.WriteLine(names[i]);
            }
            for(int counter = 1; counter<=10; counter++)
            {
                Console.WriteLine(counter);
            }
            //write out numbers from 50 to 100
            for(int counter=50; counter<=100; counter++)
            {
                Console.WriteLine(counter);
            }

            string greetings = "My name is Jackie";
            string[] words = greetings.Split();

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
                if(words[i]=="Jackie")
                {
                    words[i] = "Max";
                } 
            }
            Console.WriteLine(words[words.Length-1]);

            //for loops gives you more control over where and when a loop stops
            */


            //-------------In-class problems------------------
            //create and array called days with the elements monday, tuesday, etc.
            //use a for loop to print the elements to the console
            string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for(int i = 0; i< daysOfTheWeek.Length; i++)
            {
                Console.WriteLine(daysOfTheWeek[i]);
            }


            //create an int array size 25, put the numbers 1 to 25 in the array, & print those numbers to the console
            int[] numbersTo25 = new int[25];
            for(int i = 0; i < numbersTo25.Length; i++)
            {
                numbersTo25[i] = i+1;
                Console.WriteLine(numbersTo25[i]);
            }


            //start with the string "Once upon a time" and create an array called storyWords using the split method
            //reverse the order of the elements in the array and using a for loop, print each word
            string storyWords = "Once upon a time";
            string[] words = storyWords.Split(); //splitting it on the white space
            for(int i = 0; i <words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            Array.Reverse(words);
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            //while loops
            Console.WriteLine("Do you want to play a game?");
            string playAgain = Console.ReadLine();
            while(playAgain == "yes")
            {
                Console.WriteLine("It's a rematch");
                Console.WriteLine("Do you want to play again?");
                playAgain = Console.ReadLine();
            }

            Console.WriteLine("What is your favorite Roy G. Biv color?");
            string userColor = Console.ReadLine();
            //bool isRoygbivColor = false;    // name boolean variables "is.."
            while(userColor != "red")
            {
                Console.WriteLine("Sorry, that is not the correct color. Please try again..");
            }
            Console.WriteLine("That is correct.");  //this will run if the while loop condition not met


            //do while loops
            string playAgainToo;
            do
            {
                Console.WriteLine("Do you want to build a snowman?");
                Console.WriteLine("That was fun");
                Console.WriteLine("Do you want to build another one?");
                playAgainToo = Console.ReadLine();
            }
            while (playAgainToo == "yes");
        }
    }
}
