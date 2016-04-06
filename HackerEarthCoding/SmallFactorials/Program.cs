using System;

namespace SmallFactorials
{
    class SmallFactorials
    {
        static void Main(string[] args)
        {
            int numberofInput, inputForFactorial;
            numberofInput = int.Parse(Console.ReadLine());
            while (numberofInput > 0)
            {
                char[] factorialNumber = new char[500];
                for (int index = 0; index < factorialNumber.Length; index++)
                {
                    factorialNumber[index] = '\0';
                }
                inputForFactorial = int.Parse(Console.ReadLine());
                if (inputForFactorial > 1)
                {
                    int number = inputForFactorial, i = 0;
                    while (number > 0)
                    {
                        factorialNumber[i] = (char)(number % 10 + 48);
                        number = number / 10;
                        i++;
                    }
                    inputForFactorial--;
                    while (inputForFactorial > 1)
                    {
                        long sum = 0;
                        for (i = 0; factorialNumber[i] != '\0'; i++)
                        {
                            sum = sum + (inputForFactorial * ((int)(factorialNumber[i]) - 48));
                            factorialNumber[i] = (char)(sum % 10 + 48);
                            sum = sum / 10;
                        }
                        while (sum > 0)
                        {
                            factorialNumber[i] = (char)(sum % 10 + 48);
                            sum = sum / 10;
                            i++;
                        }
                        inputForFactorial--;
                    }
                    for (i = i - 1; i >= 0; i--)
                    {
                        Console.Write("{0}", factorialNumber[i]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("1");
                }
                numberofInput--;
            }
        }
    }
}
