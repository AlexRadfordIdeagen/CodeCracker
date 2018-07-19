using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCracker
{
    static class A1Z26
    { 
        private static string[] alphabetArray = { string.Empty, "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private static IEnumerable<string> alphaList = alphabetArray.Cast<string>();

        private static string IntToChar(int value)
        {
            return alphaList.ElementAt(value);
        }
        private static int CharToInt(string value)
        {
            int TextIndex = Array.FindIndex(alphabetArray, m => m == value);
                return TextIndex;
        }

        public static string A1Z26EncryptionInput()
        {
            string response;
            Console.WriteLine("Please provide your word/words: Example Hello World");
            response = Console.ReadLine().ToUpper();
            EncryptA1Z26(response);
            return response;
        }
        private static void EncryptA1Z26(string input)
        {
            StringBuilder result = new StringBuilder();

            string[] words = input.Split(' ');
            foreach (var word in words)
            {
                if (words.First() == word)
                {
                }
                else
                {
                    result.Append(" ");
                }
                foreach (var letter in word)
                {
                    if (word.First() == letter)
                    {
                        result.Append(CharToInt(letter.ToString()));
                    }
                    else
                    {
                        result.Append($"-{CharToInt(letter.ToString())}");

                    }
                }
            }
            Console.WriteLine(result);

        }
        public static void DecryptA1Z26(string code)
        {
            StringBuilder result = new StringBuilder();
            var words = code.Split(' ');
            foreach (var word in words)
            {
                if (words.First() == word)
                {

                }

                else
                {
                    result.Append(" ");
                }

                string[] numbers = word.Split('-');
                foreach (var number in numbers)
                {
                    int num = Int32.Parse(number);
                    result.Append(IntToChar(num).ToLower());
                }
            }
            Console.WriteLine(result);



            Console.ReadLine();
        }

        public static string A1Z26DecryptionInput()
        {
            string response;
            Console.WriteLine("Please enter your code seperated by (-): Example 8-5-12-12-15 23-15-18-12-4");
            response = Console.ReadLine();
            DecryptA1Z26(response);
            return response;
        }


    }
}
