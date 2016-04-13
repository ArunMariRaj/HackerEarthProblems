using System;
using System.Collections.Generic;

namespace StringCompilerVersion
{
    class CompilerVersion
    {
        //This code follows the logic of another submission
        static void Main()
        {
            string line;
            List<string> lines = new List<string>();
            while ((line = Console.ReadLine()) != null)
            {
                lines.Add(line);
            }

            int positionOfComment;
            string modifiedLine;
            string lineToBeModified = string.Empty;
            string lineToBeUnmodified = string.Empty;
            for (int i = 0; i < lines.Count; i++)
            {
                positionOfComment = lines[i].IndexOf("//");
                if (positionOfComment >= 0)
                {
                    lineToBeModified = lines[i].Substring(0, positionOfComment);
                    lineToBeUnmodified = lines[i].Substring(positionOfComment);
                    modifiedLine = lineToBeModified.Replace("->", ".") + lineToBeUnmodified;
                }
                else
                {
                    modifiedLine = lines[i].Replace("->", ".");
                }
                Console.WriteLine(modifiedLine);
            }
        }
    }
}
