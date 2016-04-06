using System;

namespace TrailingZerosInFactorial
{
    class TrailingZerosInFactorial
    {
        static void Main()
        {
            int inputNumber;
            var keyedInput = Console.ReadLine();
            if (int.TryParse(keyedInput, out inputNumber) && (inputNumber >= 1 && inputNumber <= 1000))
            {
                char[] factorialNumber = new char[3000];
                for (int incrementor = 0; incrementor < factorialNumber.Length; incrementor++)
                {
                    factorialNumber[incrementor] = '\0';
                }

                if (inputNumber > 1)
                {
                    int number = inputNumber, index = 0;
                    while (number > 0)
                    {
                        factorialNumber[index] = (char)(number % 10 + 48);
                        number = number / 10;
                        index++;
                    }
                    inputNumber--;
                    while (inputNumber > 1)
                    {
                        long sum = 0;
                        for (index = 0; factorialNumber[index] != '\0'; index++)
                        {
                            sum = sum + (inputNumber * ((factorialNumber[index]) - 48));
                            factorialNumber[index] = (char)(sum % 10 + 48);
                            sum = sum / 10;
                        }
                        while (sum > 0)
                        {
                            factorialNumber[index] = (char)(sum % 10 + 48);
                            sum = sum / 10;
                            index++;
                        }
                        inputNumber--;
                    }
                    int trailingZeroCount = 0;
                    bool firstOccurenceOfInteger = false;
                    foreach (char digit in factorialNumber)
                    {
                        if (digit == '0' && !firstOccurenceOfInteger)
                        {
                            trailingZeroCount++;
                        }
                        else
                        {
                            firstOccurenceOfInteger = true;
                        }
                    }
                    Console.WriteLine("{0}", trailingZeroCount);
                }
                else
                    Console.WriteLine("0");
            }
        }
    }
}