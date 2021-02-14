using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Kayla", 28);
            Console.ReadLine();
        }
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
     
}