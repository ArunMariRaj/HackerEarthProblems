using System;

namespace BestInternetBrowserRemoveVowelsFromString
{
    class BestInternetBrowserRemoveVowelsFromString
    {
        static void Main(string[] args)
        {
            int noOfInputs;
            char[] vowelArray = { 'a', 'e', 'i', 'o', 'u' };
            noOfInputs = int.Parse(Console.ReadLine());
            while (noOfInputs > 0)
            {
                int count = 0;
                string str = Console.ReadLine();
                foreach (var chr in str)
                {
                    if (chr != vowelArray[0] && chr != vowelArray[1] && chr != vowelArray[2] && chr != vowelArray[3] && chr != vowelArray[4])
                    {
                        count++;
                    }
                }
                noOfInputs--;
                Console.WriteLine("{0}/{1}", count - 3, str.Length);
            }
        }
    }
}
