using System;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
        bool alreadyExists;
        string[] outputStrings = new string[]{};

        for (int i = 0; i < strings.Length; i++)
            {
            alreadyExists = false;
            for (int j = 0; j < outputStrings.Length; j++)
                {
                if (strings[i] == outputStrings[j])
                alreadyExists = true;
                }
                    if (alreadyExists == false)
                    {
                    Array.Resize<string>(ref outputStrings, outputStrings.Length + 1);
                    outputStrings[outputStrings.Length - 1] = strings[i];
                    }
            }
            Console.WriteLine("Duplicate strings have been removed from this array");
            return outputStrings;
        }
    }
}