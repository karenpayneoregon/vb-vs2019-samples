Option Infer On

Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports System.Windows.Interop
Imports Microsoft.Win32.SafeHandles

Public Class CursorHelper

    Private NotInheritable Class NativeMethods
        Public Structure IconInfo
            Public fIcon As Boolean
            Public xHotspot As Integer
            Public yHotspot As Integer
            Public hbmMask As IntPtr
            Public hbmColor As IntPtr
        End Structure

        Private Sub New()
        End Sub

        <DllImport("user32.dll")>
        Public Shared Function CreateIconIndirect(ByRef icon As IconInfo) As SafeIconHandle
        End Function

        <DllImport("user32.dll")>
        Public Shared Function DestroyIcon(hIcon As IntPtr) As Boolean
        End Function

        <DllImport("user32.dll")>
        Public Shared Function GetIconInfo(hIcon As IntPtr, ByRef pIconInfo As IconInfo) _
            As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function
    End Class

    <SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode:=True)>
    Private Class SafeIconHandle
        Inherits SafeHandleZeroOrMinusOneIsInvalid

        Public Sub New()
            MyBase.New(True)
        End Sub

        Protected Overrides Function ReleaseHandle() As Boolean
            Return NativeMethods.DestroyIcon(handle)
        End Function

    End Class

    Private Shared Function InternalCreateCursor(bmp As Bitmap) As Cursor

        Dim iconInfo = New NativeMethods.IconInfo()
        NativeMethods.GetIconInfo(bmp.GetHicon(), iconInfo)

        iconInfo.xHotspot = 0
        iconInfo.yHotspot = 0
        iconInfo.fIcon = False

        Dim cursorHandle As SafeIconHandle = NativeMethods.CreateIconIndirect(iconInfo)

        Return CursorInteropHelper.Create(cursorHandle)

    End Function
    ''' <summary>
    ''' Use bitmap image from project resources.
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function CreateDropLabelCursorFromImage() As Cursor

        Dim iconInfo As New NativeMethods.IconInfo()

        '
        ' Here we read an image from project resources.
        '
        NativeMethods.GetIconInfo(My.Resources.Dynamic.GetHicon(), iconInfo)

        iconInfo.xHotspot = 0
        iconInfo.yHotspot = 0
        iconInfo.fIcon = False

        Dim cursorHandle As SafeIconHandle = NativeMethods.CreateIconIndirect(iconInfo)

        Return CursorInteropHelper.Create(cursorHandle)

    End Function
End Class
