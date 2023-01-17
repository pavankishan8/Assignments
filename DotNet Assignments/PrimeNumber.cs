using System;

namespace Assignments
{
    class PrimeNumber
    {
        static bool isPrimeNumber(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number to check:");
                int num = int.Parse(Console.ReadLine());
                bool res = isPrimeNumber(num);
                if (res)
                    Console.WriteLine("Prime Number\n");
                else
                    Console.WriteLine("Not a Prime Number\n");
            }
        }
        
    }
}
