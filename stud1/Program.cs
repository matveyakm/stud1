using System;
using System.Collections.Generic;

namespace stud1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            double sumOfSpI = 0;
            double average = 0;
            List<int> numbers = new List<int>();
            for (int i = 298435; i <= 363249; i++) // for (int i = 298435; i <= 363249; i++)
            {
                for (int d = 2; d < Math.Sqrt(i); d++) //for(int d = 2; d < Math.Sqrt(i); d++)
                {
                    if (i % d == 0)
                    {
                        int anotherD = i / d;
                        if (isPrime(d) == true && isPrime(anotherD) == true && anotherD != d)
                        {
                            sumOfSpI += i;
                            numbers.Add(i);
                           // Console.WriteLine("Добавили "+i);
                        }
                    }
                }
            }
            average = sumOfSpI / numbers.Count;
            double min = 0;
            int minKey = 0;
            foreach(int number in numbers)
            {
                
                if (Math.Abs(number - average) <= min || min == 0)
                {
                    minKey = number; min = Math.Abs(number - average);
                }
            }

            Console.WriteLine(numbers.Count + " " + minKey);
        }

        static bool isPrime (int x)
        {
            for(int y = 2; y <= Math.Sqrt(x); y++)
            {
                if (x % y == 0) return false;
            }
            return true;

        }
    }
}
