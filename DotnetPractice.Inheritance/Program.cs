using System;

namespace DotnetPractice.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

                Book b1 = new Book("Book1", "Author1", 500, 50.80M);
                Magazine m1 = new Magazine("Magazine1","Publisher1", 100, 3.99M);

                Console.WriteLine($"{b1.Name}, {b1.Author}");
                Console.WriteLine($"{m1.Name}, {m1.Publisher}");
        }
    }
}
