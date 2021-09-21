using System;

namespace learn_.net_1_21_09_2021
{
    class Program
    {
        static void Main()
        {
            for(int i = 0; i <= 200; i++)
            {

                Console.Write($"{i} ");

                if(i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if(i % 5 == 0)
                {
                    Console.Write("Buzz");
                }

                Console.WriteLine("");

            }
        }
    }
}
