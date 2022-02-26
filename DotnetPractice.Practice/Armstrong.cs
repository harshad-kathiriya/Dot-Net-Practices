
// 153 
// 1*1*1 =   1
// 5*5*5 = 125
// 3*3*3 =  27
//        -----
//         153 -- Answaer match with input number so This is Armstrong number

using System;
namespace DotnetPractice.Practice
{
    class Armstrong
    {
        public void CheckArmstrong(int n)
        {
            int sum =0;
            int m = n;
            while(m>0)
            {
                int reminder = m %10;
                sum += (reminder * reminder * reminder);
                m = m/10; 
            }
            
            if(n == sum)
                Console.WriteLine($"{n} is armstrong number.");
            else 
                Console.WriteLine($"{n} is not armstrong number.");
        }
    }
}