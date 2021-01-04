Option Infer On

Imports System.Runtime.InteropServices


Namespace Classes
	Public Module CueBannerTextCode
		<DllImport("user32.dll", CharSet:=CharSet.Auto)>
		Private Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> lParam As String) As Int32
		End Function
		<DllImport("user32", EntryPoint:="FindWindowExA", ExactSpelling:=True, CharSet:=CharSet.Ansi, SetLastError:=True)>
		Private Function FindWindowEx(hWnd1 As IntPtr, hWnd2 As IntPtr, lpsz1 As String, lpsz2 As String) As IntPtr
		End Function
		Private Const EM_SETCUEBANNER As Integer = &H1501
		''' <summary>
		''' Set place holder
		''' </summary>
		''' <param name="control">Controls e.g. TextBox</param>
		''' <param name="text">Place holder text to display when control loses focus with no text</param>
		Public Sub SetCueText(control As Control, text As String)

			If TypeOf control Is ComboBox Then
				Dim editHWnd = FindWindowEx(control.Handle, IntPtr.Zero, "Edit", Nothing)
				If Not (editHWnd = IntPtr.Zero) Then
					SendMessage(editHWnd, EM_SETCUEBANNER, 0, text)
				End If
			ElseIf TypeOf control Is TextBox Then
				SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
			End If
		End Sub

	End Module
End Namespace
