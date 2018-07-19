using System;
using System.Text;

namespace CodeCracker
{
    public class ASCII
    {
        public static void ASCIIEncryption()
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

        public static void ASCIIDecryption()
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
    }
}
