using System;
using EncryptionServices;

namespace EncryptionServicesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
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

            Console.ReadLine();

        }
    }
}
