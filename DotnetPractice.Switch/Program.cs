using System;

namespace DotnetPractice.Switch
{
    class Program
    {
        static void Main(string[] args)
        {
           int val = 20;

           // switch statement
           switch(val) {
               case 10:
                Console.WriteLine("Value is 10");
                break;
               case 20:
               case 30:               
                Console.WriteLine("Value is between 20 and 30");
                break;
               default:
                Console.WriteLine("Value is something else");
                break;
           }

        }
    }
}
