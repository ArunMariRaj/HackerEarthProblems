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
                Console.WriteLine("{0}",terribleChandu.ReverseString(stringInput.ToCharArray()));
                numberOfStrings--;
            }
        }

        public string ReverseString(char[] inputString)
        {
            int stringLength = inputString.Length;
            int reversalPivot = stringLength / 2;
            char temp;
            for (int i = 0; i < reversalPivot; i++)
            {
                stringLength--;
                temp = inputString[i];
                inputString[i] = inputString[stringLength];
                inputString[stringLength] = temp;
            }
            return new string(inputString);
        }
    }
}
