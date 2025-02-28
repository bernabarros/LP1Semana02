using System;
using System.ComponentModel.Design;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Generate a random number for variable
            Random rnd = new Random();
            int numberToGuess = rnd.Next(31);
            //Cicle variable
            Boolean active = true;
            //Input variable to compare with random number variable
            string num_guess;
            int int_guess;
            //Counting variable
            int num_tries = 0;

            //Cicle
            while(active == true)
            {
                //Input request and conversion to int
                Console.Write("Insert number: ");
                num_guess = Console.ReadLine();
                int_guess = int.Parse(num_guess);

                //Check if number is between 0 and 30
                if (int_guess < 0 | int_guess > 30 )
                {
                    Console.WriteLine("Numbers must be between 0 and 30. "+
                    "Try again.");
                    num_tries = ++num_tries;
                }
                //Check if input number is lower than target number
                else if (int_guess < numberToGuess)
                {
                    Console.WriteLine($"The hidden number is higher than "+
                    $"{int_guess}. Try again");
                    num_tries = ++num_tries;
                }
                //Check if input number is higher than target number
                else if (int_guess > numberToGuess)
                {
                    Console.WriteLine($"The hidden number is lower than "+
                    $"{int_guess}. Try again");
                    num_tries = ++num_tries;
                }
                //Correct number message and cicle close
                else
                {
                    num_tries = ++num_tries;
                    
                    Console.WriteLine($"You found the hidden number "+
                    $"{numberToGuess} after {num_tries} tries");
                    active = false;
                }
            }
        }
    }
}
