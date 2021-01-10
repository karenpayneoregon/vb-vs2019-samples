Imports System.Runtime.CompilerServices

Namespace LanguageExtensions

    Public Module ControlExtensions
        ''' <summary>
        ''' Protection against cross thread exceptions
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="control"></param>
        ''' <param name="action"></param>
        ''' <returns></returns>
        <Extension>
        Public Function InvokeIfRequired(Of T As Control)(control As T, action As Action(Of T)) As IAsyncResult

            If control.InvokeRequired Then

                Try

                    Return control.BeginInvoke(New Action(Of T, Action(Of T))(AddressOf InvokeIfRequired), New Object() {control, action})

                Catch ex As Exception

                    Return Nothing

                End Try

            Else

                action(control)
                Return Nothing

            End If

        End Function

        <Extension>
        Public Iterator Function Descendants(Of T As Class)(control As Control) As IEnumerable(Of T)

            For Each child As Control In control.Controls

                Dim thisControl As T = TryCast(child, T)
                If thisControl IsNot Nothing Then
                    Yield CType(thisControl, T)
                End If

                If child.HasChildren Then

                    For Each descendant As T In child.Descendants(Of T)()
                        Yield descendant
                    Next

                End If
            Next

        End Function

        <Extension>
        Public Function ButtonList(pControl As Control) As List(Of Button)

            Return pControl.Descendants(Of Button)().ToList()

        End Function

    End Module
End Namespace