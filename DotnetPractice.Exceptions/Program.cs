using System;

namespace DotnetPractice.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 110;
            int y = 0;

            try
            {
                if(x>100) {
                    throw new ArgumentOutOfRangeException("x","x has to be 1000 or less");
                }
                int z = x/y;
                Console.WriteLine("result = " + z);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentOutOfRangeException e) {
                Console.WriteLine("Argument out of range exception.");
                Console.WriteLine(e.Message);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("end of program");                
            }

        }
    }
}
