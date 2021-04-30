Imports System.Security

Namespace Modules
    Public Module Helpers
        Private entropy() As Byte = Text.Encoding.Unicode.GetBytes("Salt Is Not A Password")

        Public Function EncryptString(input As SecureString) As String

            Dim encryptedData() As Byte = Cryptography.ProtectedData.Protect(Text.Encoding.Unicode.GetBytes(ToInsecureString(input)), entropy, Cryptography.DataProtectionScope.CurrentUser)

            Return Convert.ToBase64String(encryptedData)

        End Function

        Public Function DecryptString(encryptedData As String) As SecureString

            Try

                Dim decryptedData() As Byte = Cryptography.ProtectedData.Unprotect(Convert.FromBase64String(encryptedData), entropy, Cryptography.DataProtectionScope.CurrentUser)

                Return ToSecureString(Text.Encoding.Unicode.GetString(decryptedData))

            Catch
                Return New SecureString()
            End Try

        End Function

        Public Function ToSecureString(input As String) As SecureString

            Dim secure As New SecureString()

            For Each character As Char In input
                secure.AppendChar(character)
            Next

            secure.MakeReadOnly()
            Return secure
        End Function

        Public Function ToInsecureString(input As SecureString) As String

            Dim returnValue As String

            Dim ptr As IntPtr = Runtime.InteropServices.Marshal.SecureStringToBSTR(input)

            Try
                returnValue = Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr)
            Finally
                Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr)
            End Try

            Return returnValue

        End Function

    End Module
End Namespace