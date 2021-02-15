using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses)
            {
                if (guessCount< guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
              
            }
            if (outOfGuesses)
            {
                Console.Write("Loserrr");
            }
            else
            {
                Console.Write("You win!");
            }
            

                Console.ReadLine();
        }

       
        
    }
     
}

