

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ZerosInFactorial
{
    class ZerosInFactorial
    {
        static Dictionary<long, BigInteger> lookupTable = new Dictionary<long, BigInteger>();
        static BigInteger preExistingFactorialValue;
        static void Main()
        {
            lookupTable.Add(1, 1);
            BigInteger factorial = new BigInteger();
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {

                long zeroCount = 0;
                long input = long.Parse(Console.ReadLine());
                long dummy = 1;
                if (lookupTable.ContainsKey(input))
                {
                    lookupTable.TryGetValue(input, out preExistingFactorialValue);
                    factorial = preExistingFactorialValue;
                    dummy = input + 1;
                }
                else
                {
                    lookupTable.TryGetValue(lookupTable.Keys.Max(), out preExistingFactorialValue);
                    factorial = preExistingFactorialValue;
                    dummy = lookupTable.Keys.Max() + 1;
                }
                while (dummy <= input)
                {
                    factorial *= dummy;
                    lookupTable.Add(dummy, factorial);
                    dummy++;
                }
                zeroCount += factorial.ToString().Count(x => x == '0');
                Console.WriteLine("{0}", zeroCount);
                n--;
            }
            Console.ReadLine();
        }
    }
}
