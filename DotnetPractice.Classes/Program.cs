using System;

namespace DotnetPractice.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Book1", "Author1", 500);
            Book b2 = new Book("Book2", "Author2", 250);
            
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());
        }
    }
}
