using System;

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
                Atbash.AtbashCracker();
            }
            if (response == "2")
            {
                Atbash.AtbashCracker();
            }
            Console.ReadLine();
        }
        private static void InputAsciiToText()
        {
            string response = OptionSelected("ASCII");

            if (response == "1")
            {
                ASCII.ASCIIDecryption();
            }

            if (response == "2")
            {
                ASCII.ASCIIEncryption();
            }

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
                response = A1Z26.A1Z26DecryptionInput();
            }
            if (response == "2")
            {
                response = A1Z26.A1Z26EncryptionInput();
            }
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
