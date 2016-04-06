using System;
using System.Collections.Generic;

namespace ByteLandianGoldCoinDynamicProgramming
{
    class ByteLandianGoldCoinDynamicProgramming
    {
        static Dictionary<long, long> _lookup = new Dictionary<long, long>();
        static long DivideNumber(long byteLandianCoin)
        {
            long exchangeValue;
            if (byteLandianCoin == 0)
                return byteLandianCoin;
            if (_lookup.TryGetValue(byteLandianCoin, out exchangeValue))
                return exchangeValue;
            long calculatedExchangeValue = DivideNumber(byteLandianCoin / 4) + DivideNumber(byteLandianCoin / 3) + DivideNumber(byteLandianCoin / 2);
            if (calculatedExchangeValue > byteLandianCoin)
            {
                if (!_lookup.ContainsKey(byteLandianCoin))
                {
                    _lookup.Add(byteLandianCoin, calculatedExchangeValue);
                }
                return calculatedExchangeValue;
            }
            else
            {
                if (!_lookup.ContainsKey(byteLandianCoin))
                {
                    _lookup.Add(byteLandianCoin, byteLandianCoin);
                }
                return byteLandianCoin;
            }
        }
        static void Main(string[] args)
        {
            long byteLandianCoin = long.Parse(Console.ReadLine());
            long americanCoin;
            while (byteLandianCoin != 0)
            {
                americanCoin = DivideNumber(byteLandianCoin);
                if (americanCoin > byteLandianCoin)
                {
                    Console.WriteLine("{0}", americanCoin);
                }
                else
                    Console.WriteLine("{0}", byteLandianCoin);
                try
                {
                    byteLandianCoin = long.Parse(Console.ReadLine());
                }
                catch
                {
                    byteLandianCoin = 0;
                }
            }
        }
    }
}