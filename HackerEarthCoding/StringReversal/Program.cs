using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    class TerribleChandu
    {
        static void Main(string[] args)
        {
            TerribleChandu terribleChandu = new TerribleChandu();
            string stringInput;
            int numberOfStrings = int.Parse(Console.ReadLine());
            while(numberOfStrings>0)
            {
                stringInput = Console.ReadLine();
                Console.WriteLine("{0}",terribleChandu.ReverseString(stringInput));
                numberOfStrings--;
            }
        }

        public string ReverseString(string inputString)
        {
            char[] outputString = inputString.ToCharArray();
            int stringLength = outputString.Length;
            int reversalPivot = stringLength / 2;
            char temp;
            for (int i = 0; i < reversalPivot; i++)
            {
                stringLength--;
                temp = outputString[i];
                outputString[i] = outputString[stringLength];
                outputString[stringLength] = temp;
            }
            return new string(outputString);
        }
    }
}
