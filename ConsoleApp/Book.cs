using System;
namespace ConsoleApp
{
    public class Book
    {
        //class atributes
        public string title;
        public string author;
        public int pages;

        //constructor is linked to class
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
