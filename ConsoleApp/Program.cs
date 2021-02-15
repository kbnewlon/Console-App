using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFemale = true;
            bool isTall = false;

            if (isFemale || isTall)
            {
                Console.WriteLine("You are a tall badass");
            } else if (isFemale && !isTall) {
                Console.WriteLine("You are short badass!");
            } else if (!isFemale && isTall) {
                Console.WriteLine("You're not a badass but you're tall!");
            } else
            {
                Console.WriteLine("You are not a badass AND you're short");
            }

            Console.ReadLine();
        }

       
    }
     
}