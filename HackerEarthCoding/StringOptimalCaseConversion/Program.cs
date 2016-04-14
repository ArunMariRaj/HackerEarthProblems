using System;

namespace StringOptimalCaseConversion
{
    class MarutAndStrings
    {
        static void Main()
        {
            int numberOfStringsToProcess;
            string stringArray;
            if (int.TryParse(Console.ReadLine(), out numberOfStringsToProcess))
            {
                if (numberOfStringsToProcess >= 1 && numberOfStringsToProcess <= 10)
                {
                    for (int i = 0; i < numberOfStringsToProcess; i++)
                    {
                        int lengthOfUpperCase = 0;
                        int lengthOfLowerCase = 0;
                        stringArray = Console.ReadLine();
                        if (stringArray.Length >= 1 && stringArray.Length <= 100)
                        {                            
                            for (int index = 0; index < stringArray.Length; index++)
                            {
                                if (stringArray[index] >= 65 && stringArray[index] <= 90)
                                {
                                    lengthOfUpperCase++;
                                }
                                else if (stringArray[index] >= 97 && stringArray[index] <= 122)
                                {
                                    lengthOfLowerCase++;
                                }
                            }
                            if (lengthOfLowerCase>0 || lengthOfUpperCase>0)
                            {
                                Console.WriteLine("{0}",Math.Min(lengthOfUpperCase,lengthOfLowerCase));
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Test");
                }
            }
            else
            {
                Console.WriteLine("Invalid Test");
            }
        }
    }
}
