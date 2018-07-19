using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCracker
{
   public static class Atbash
    {
        private static string[] alphabetArray = { string.Empty, "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public static IEnumerable<string> alphaList = alphabetArray.Cast<string>();
        private static string[] backwardsAlphabetArray = { string.Empty, "Z", "Y", "X", "W", "V", "U", "T", "S", "R", "Q", "P", "O", "N", "M", "L", "K", "J", "I", "H", "G", "F", "E", "D", "C", "B", "A" };
        public static IEnumerable<string> backwardsAlphaList = backwardsAlphabetArray.Cast<string>();

        private static string Decrypt(string value)
        {
            int TextIndex = Array.FindIndex(alphabetArray, m => m == value);

            return backwardsAlphaList.ElementAt(TextIndex);
        }
        private static string Encrypt(string value)
        {
            int TextIndex = Array.FindIndex(backwardsAlphabetArray, m => m == value);

            return alphaList.ElementAt(TextIndex);
        }
        public static void AtbashCracker()
        {
            string response;
            StringBuilder result = new StringBuilder();
            Console.WriteLine("Please input your Text for encryption or Code for decryption");
            response = Console.ReadLine().ToUpper();
            string[] word = response.Split();
            foreach (var letter in response)
            {
                string stringLetter = letter.ToString();
                result.Append(Decrypt(stringLetter));
            }
            Console.WriteLine(result);
        }

    }
}
