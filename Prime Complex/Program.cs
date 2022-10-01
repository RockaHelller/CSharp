using System;

namespace Prime_and_Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int count = 0;
            if (n == 1 || n == 0)
            {
                Console.WriteLine("Duzgun reqem daxil edin");

            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("n is a prime number");
                }
                else
                {
                    Console.WriteLine("n is a complex number");
                }
            }
        }
    }
}
