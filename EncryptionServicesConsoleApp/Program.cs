using System;
using EncryptionServices;
using System.Xml;
using System.Globalization;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace EncryptionServicesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "\\/Date(1595962688000)\\/";

            if (s[0] == '\\')
            {
                if (s.Length >= 9 && s.Contains("/Date(", StringComparison.Ordinal) && s.EndsWith(")\\/", StringComparison.Ordinal))
                {
                    var aaa = s.ToCharArray();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                }
            }
            StringReference value = new StringReference("/Date(1595962688000)\\/") ;
            

            Console.ReadLine();
        }

        private static void Work()
        {
            string fullName = "Karen Payne";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Original string: {fullName}");
            Console.ResetColor();

            Console.WriteLine();

            var encryptString = Helpers.Encrypt(fullName);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Encrypted string");
            Console.ResetColor();

            Console.WriteLine(encryptString);
            Console.WriteLine();
            var decryptedString = Helpers.DeEncrypt(encryptString);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Decrypted string: {fullName}");
            Console.ResetColor();

            Console.WriteLine(decryptedString);
        }
    }
}
