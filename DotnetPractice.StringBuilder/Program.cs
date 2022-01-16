using System;
using System.Text;

// StringBuilder Class
//https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-6.0
namespace DotnetPractice.StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            int jumpedCount = 10;
            string[] animals = { "goats", "cats", "pigs"};

             System.Text.StringBuilder sb = new System.Text.StringBuilder("Initial string. ", 200);

            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

            sb.Append("The quick brown fox ");
            sb.Append("jumped over the lazy dog ");

            sb.AppendLine();

            sb.AppendFormat("He did this {0} times. ", jumpedCount);
            sb.AppendLine();

            sb.Append("He also jumped over. ");
            sb.AppendJoin(',',animals);

            sb.Replace("fox", "cat");

            sb.Insert(0, "This is the ");

            Console.WriteLine(sb.ToString());



        }
    }
}
