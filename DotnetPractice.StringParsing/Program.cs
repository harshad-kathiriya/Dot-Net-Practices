using System;
using System.Globalization;

// parsing string
// https://docs.microsoft.com/en-us/dotnet/standard/base-types/parsing-strings
namespace DotnetPractice.StringParsing
{
    class Program
    {
        static void Main(string[] args)
        {

            string numStr1= "1";
            string numStr2= "2.0";
            string numStr3= "3,000";
            string numStr4= "3,000.00";
            
            int targetNum = 0;

            try
            {
                // integer
                targetNum = int.Parse(numStr1);
                Console.WriteLine(targetNum);

                targetNum = int.Parse(numStr2, NumberStyles.Float);
                Console.WriteLine(targetNum);

                targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
                Console.WriteLine(targetNum);

                targetNum = int.Parse(numStr4, NumberStyles.Float | NumberStyles.AllowThousands);
                Console.WriteLine(targetNum);


                // boolean
                Console.WriteLine($"{bool.Parse("True")}");

                // float
                Console.WriteLine($"{float.Parse("1.235"):F2}");

            }
            catch
            {
                Console.WriteLine("Conversion failed.");
            }
            
            bool succeeded = false;
            succeeded = int.TryParse(numStr1, out targetNum);
            if(succeeded) 
            {
                Console.WriteLine($"{targetNum}");
            }


        }
    }
}
