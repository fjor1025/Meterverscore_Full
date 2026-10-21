Public Module IPtoFlag
    Public Function getflag(ByVal ipc As String) As Image
        Try
            If String.IsNullOrWhiteSpace(ipc) Then
                Return GetDefaultFlag()
            End If
            Dim upper As String = BTEngine.GeoIP0.LookupCountryCode(ipc.Trim()).ToUpper()
            If BTEngine.MainForm IsNot Nothing AndAlso BTEngine.MainForm.Flags_images IsNot Nothing Then
                Dim num1 As Integer = BTEngine.MainForm.Flags_images.Images.IndexOfKey(upper)
                If num1 = -1 Then
                    num1 = BTEngine.MainForm.Flags_images.Images.IndexOfKey("-1")
                End If
                If num1 >= 0 AndAlso num1 < BTEngine.MainForm.Flags_images.Images.Count Then
                    Return BTEngine.MainForm.Flags_images.Images(num1)
                End If
            End If
        Catch ex As Exception
        End Try
        Return GetDefaultFlag()
    End Function

    Private Function GetDefaultFlag() As Image
        Try
            If BTEngine.MainForm IsNot Nothing AndAlso BTEngine.MainForm.Flags_images IsNot Nothing AndAlso BTEngine.MainForm.Flags_images.Images.Count > 0 Then
                Dim idx As Integer = BTEngine.MainForm.Flags_images.Images.IndexOfKey("-1")
                If idx >= 0 Then
                    Return BTEngine.MainForm.Flags_images.Images(idx)
                Else
                    Return BTEngine.MainForm.Flags_images.Images(0)
                End If
            End If
        Catch ex As Exception
        End Try
        Return New Bitmap(25, 25)
    End Function
    Public Function GetCountryName(ByVal ipc As String) As String
        Dim contrys As String = ""
        Try
            contrys = BTEngine.GeoIP0.LookupCountryName(ipc.Trim())
        Catch ex As Exception
            contrys = "Unkown"
        End Try
        Return contrys
    End Function
End Module
