using System;
using System.Security;
using SSC = System.Security.Cryptography;

namespace EncryptionServices
{
    public static class Helpers
    {
        private static byte[] entropy = System.Text.Encoding.Unicode.GetBytes("Salt Is Not A Password");

        public static string Encrypt(string sender) => EncryptString(ToSecureString(sender));
        public static string DeEncrypt(string sender) => ToInsecureString(DecryptString(sender));

        public static string EncryptString(SecureString input)
        {

            var encryptedData = SSC.ProtectedData.Protect(
                System.Text.Encoding.Unicode.GetBytes(ToInsecureString(input)), 
                entropy, 
                SSC.DataProtectionScope.CurrentUser);

            return Convert.ToBase64String(encryptedData);

        }

        public static SecureString DecryptString(string encryptedData)
        {

            try
            {
                byte[] decryptedData = SSC.ProtectedData.Unprotect(Convert.FromBase64String(encryptedData), 
                    entropy, SSC.DataProtectionScope.CurrentUser);

                return ToSecureString(System.Text.Encoding.Unicode.GetString(decryptedData));

            }
            catch
            {
                return new SecureString();
            }

        }

        public static SecureString ToSecureString(string input)
        {

            var secure = new SecureString();

            foreach (var character in input)
            {
                secure.AppendChar(character);
            }

            secure.MakeReadOnly();
            return secure;
        }

        public static string ToInsecureString(SecureString input)
        {

            string returnValue = null;

            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(input);

            try
            {
                returnValue = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
            }

            return returnValue;

        }

    }

}
