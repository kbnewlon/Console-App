﻿using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
        }

       
        
    }


}


