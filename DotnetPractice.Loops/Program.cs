using System;

namespace DotnetPractice.Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10;

            // for loop
            for(int i=0; i < count; i++) {
                Console.WriteLine(i);
            }

            // foreach loop
            string str = "dotnet";
            foreach(char d in str) {
                Console.WriteLine(d);
            }

            // while loop
            int c =0;
            while(c < count) {
                Console.WriteLine(c);
                c++;
            }

            // break and continue
            int counter = 20;
            for(int j=0; j<20; j++) {
                if(j==15) {
                    break;
                } 
                if(j<10) {
                    continue;
                } 
                Console.WriteLine("break and continue loop " + j);
            }
        }
    }
}
