using System;

namespace FindEvenNumbers
{
    class FindEvenNumbers
    {
        static void Main(string[] args)
        {
            long n;
            n = long.Parse(Console.ReadLine());
            while (n != -1)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("{0}", n);
                }
                n = long.Parse(Console.ReadLine());
            }
        }
    }
}