using System;

namespace TenaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 1;
            while(num<=30)
            {
                if (num%3==0 && num%5==0 )
                {
                    Console.WriteLine("FizzBuzz");
                    num += 1;
                }
                else if (num%3 ==0)
                {
                    Console.WriteLine("Fizz");
                    num +=1;
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    num += 1;
                }
                else
                {
                    num++;
                }
            }
        }
    }
}
