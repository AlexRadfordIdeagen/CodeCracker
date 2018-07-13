using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeCracker
{
    static class A1Z26
    { 
        private static string[] alphabetArray = { string.Empty, "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public static IEnumerable<string> alphaList = alphabetArray.Cast<string>();

        public static string IntToChar(int value)
        {
            return alphaList.ElementAt(value);
        }
        public static int CharToInt(string value)
        {
            int TextIndex = Array.FindIndex(alphabetArray, m => m == value);
                return TextIndex;
        }
    }
}
