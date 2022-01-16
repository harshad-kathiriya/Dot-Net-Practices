using System;

// Properties (C# Programming Guide)
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
namespace DotnetPractice.Properties
{
    class Program
    {
        static void Main(string[] args)
        {
           Book b1 = new Book("Book1", "Author1", 500);

           Console.WriteLine(b1.Name);
           Console.WriteLine(b1.Author);
           
           b1.ISBN = "10008989890";
           b1.Price = 50.10m;

           Console.WriteLine(b1.ISBN);
           Console.WriteLine($"{b1.Price:C}" );
           
           b1.Name = "Book2";
           b1.Author = "Author2";
           
           Console.WriteLine(b1.Name);
           Console.WriteLine(b1.Author);
           
        }
    }
}
