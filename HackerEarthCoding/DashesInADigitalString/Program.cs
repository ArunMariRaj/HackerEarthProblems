using System;

namespace DashesInADigitalString
{
    class DashesInADigitalString
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int[] arr = { 6, 2, 5, 5, 4, 5, 6, 3, 7, 6 };
            int sum = 0;
            foreach (char val in num)
            {
                sum += arr[val - '0'];
            }
            Console.WriteLine("{0}", sum);
        }
    }
}
