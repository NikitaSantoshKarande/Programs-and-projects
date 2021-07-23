Module Module1
    Public Sub charlock(ByVal e)
        Dim ch As Char = e.keychar
        If Not Char.IsDigit(ch) And Asc(ch) <> 8 Then
            e.handled = True
        End If
    End Sub
    Public Sub contact_No(ByVal len As Integer)
        If len < 10 Then
            MsgBox("check Mobile Number..")
        End If
    End Sub
    Public Sub Numlock(ByVal e)
        Dim ch As Char = e.keychar
        If Char.IsDigit(ch) And Asc(ch) <> 8 Then
            e.handled = True
        End If
    End Sub
End Module
