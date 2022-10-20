using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == 4)
                {
                    a++;
                }
            }
            string[] result = new string[a];
            for (int y = 0; y < strings.Length; y++)
            {
                if (strings[y].Length == 4)
                {
                    result[b] = strings[y];
                    b++;
                }
            }
            return result;

        }
    }
}
