using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";
            int characterAge;
            characterAge = 35;


            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But did't like being " + characterAge);

            Console.ReadLine();
        }
    }
}
