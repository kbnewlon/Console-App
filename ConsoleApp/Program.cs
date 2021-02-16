using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //object is instance of the class
            // this creates a book object as book1
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Console.WriteLine(book1.title);


            Console.ReadLine();
        }

       
        
    }


}


