using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCracker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Intro();
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        InputA1Z26();
                        break;
                    case "2":
                        InputAsciiToText();
                        break;
                    case "3":
                        InputAtbash();
                        break;
                    default:
                        break;
                }
            }

        }

        private static void InputAtbash()
        {
            string response = OptionSelected("Atbash");
            if (response == "1")
            {
                AtbashEncryption();
            }
            if (response == "2")
            {
                AtbashDecryption();
            }
            Console.ReadLine();
        }

        private static void AtbashDecryption()
        {
            string response;
            StringBuilder result = new StringBuilder();
            Console.WriteLine("Please input your Atbash code");
            response = Console.ReadLine().ToUpper();
            string[] word = response.Split();
            foreach (var letter in response)
            {
                string stringLetter = letter.ToString();
                result.Append(Atbash.Decrypt(stringLetter));
            }
            Console.WriteLine(result);
        }

        private static void AtbashEncryption()
        {
            string response;
            StringBuilder result = new StringBuilder();
            Console.WriteLine("Please input your text");
            response = Console.ReadLine().ToUpper();
            foreach (var letter in response)
            {
                string stringLetter = letter.ToString();

                result.Append(Atbash.Encrypt(stringLetter));
            }
            Console.WriteLine(result);
        }

        private static void InputAsciiToText()
        {
            string response = OptionSelected("ASCII");

            if (response == "1")
            {
                ASCIIDecryption();
            }

            if (response == "2")
            {
                ASCIIEncryption();
            }

        }

        private static void ASCIIEncryption()
        {
            StringBuilder result = new StringBuilder();

            Console.WriteLine("Please input your text");
            string text = Console.ReadLine();
            foreach (char c in text)
            {
                int unicode = c;
                result.AppendFormat(unicode < 128 ? "{0} " : "(Warning this is Non-ASCII: {0}) ", unicode);
            }
            Console.WriteLine(result);
        }

        private static void ASCIIDecryption()
        {
            string response;
            StringBuilder result = new StringBuilder();
            Console.WriteLine("Please input your ASCII code");
            response = Console.ReadLine();
            string[] numbers = response.Split();
            foreach (var number in numbers)
            {
                result.Append(Char.ConvertFromUtf32(Convert.ToInt16(number)));
            }
            Console.WriteLine(result);
        }

        private static string OptionSelected(string option)
        {
            Console.Clear();
            Console.WriteLine($"You selected {option}");
            Console.WriteLine("Choose an option");
            Console.WriteLine("Decryption: 1");
            Console.WriteLine("Encryption: 2");
            string response = Console.ReadLine();
            return response;
        }

        private static void InputA1Z26()
        {
            string response = OptionSelected("A1 Z26");

            if (response == "1")
            {
                response = A1Z26DecryptionInput();
            }
            if (response == "2")
            {
                response = A1Z26EncryptionInput();
            }
        }

        private static string A1Z26EncryptionInput()
        {
            string response;
            Console.WriteLine("Please provide your word/words: Example Hello World");
            response = Console.ReadLine().ToUpper();
            EncryptA1Z26(response);
            return response;
        }

        private static string A1Z26DecryptionInput()
        {
            string response;
            Console.WriteLine("Please enter your code seperated by (-): Example 8-5-12-12-15 23-15-18-12-4");
            response = Console.ReadLine();
            DecryptA1Z26(response);
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
                        result.Append(A1Z26.CharToInt(letter.ToString()));
                    }
                    else
                    {
                        result.Append($"-{A1Z26.CharToInt(letter.ToString())}");

                    }
                }
            }
            Console.WriteLine(result);

        }

        private static void DecryptA1Z26(string code)
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
                    result.Append(A1Z26.IntToChar(num).ToLower());
                }
            }
            Console.WriteLine(result);



            Console.ReadLine();
        }

        private static void Intro()
        {
            Console.WriteLine("   ______              __                ______                           __                ");
            Console.WriteLine("  / ____/  ____   ____/ /  ___          / ____/   _____  ____ _  _____   / /__  ___    _____");
            Console.WriteLine(@" / /      / __ \ / __  /  / _ \        / /       / ___/ / __ `/ / ___/  / //_/ / _ \  / ___/");
            Console.WriteLine(@"/ /___   / /_/ // /_/ /  /  __/       / /___    / /    / /_/ / / /__   / ,<   /  __/ / /    ");
            Console.WriteLine(@"\____/   \____/ \__,_/   \___/        \____/   /_/     \__,_/  \___/  /_/|_|  \___/ /_/     ");
            Console.WriteLine("                                                                                            ");
            Console.WriteLine("-------------------------------------------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1: A1Z26 Conversion");
            Console.WriteLine("2: ASCII Conversion");
            Console.WriteLine("3: Atbash Conversion");

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
