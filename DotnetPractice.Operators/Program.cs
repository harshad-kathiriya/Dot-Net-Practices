using System;

namespace DotnetPractice.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
           int x=10, y = 20;
       
           Console.WriteLine((x+y)/x);     
           Console.WriteLine(x*y);
           Console.WriteLine(y/x);

           Console.WriteLine(x++);
           Console.WriteLine(--y);

           Console.WriteLine("--- logical operator ---");
           Console.WriteLine( x > 15 && y < 21 ); 
           Console.WriteLine( x > 20 || y < 21 ); 

           Console.WriteLine("--- null-coalescing operator ---");
           string str = "hello";
           // ??
           Console.WriteLine(str ?? "Unknown string"); 
           // ??=
           Console.WriteLine(str ??= "New string"); 


        }
    }
}
