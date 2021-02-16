using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //object is instance of the class
            // this creates a book object as book1
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            //book1.title = "Harry Potter";
            //book1.author = "JK Rowling";
            //book1.pages = 400;

            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);
            //book1.title = "Lord of the Rings";
            //book1.author = "Tolkein";
            //book1.pages = 700;

            Console.WriteLine(book2.title);


            Console.ReadLine();
        }

       
        
    }


}


//The main use of constructors is to initialize the private fields of the class while creating an instance for the class.