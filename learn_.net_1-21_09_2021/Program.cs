using System;

namespace learn_.net_1_21_09_2021
{
    class Program
    {
        static void Main()
        {
            for(int i = 0; i <= 200; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} FizzBuzz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine($"{i} Buzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine($"{i} Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
