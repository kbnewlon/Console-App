using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            //Console.WriteLine("Hello " + name);
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);

            Console.ReadLine();
        }
    }
}
