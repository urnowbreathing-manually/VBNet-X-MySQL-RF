Public Class Form1

    'Handle only Letters
    Private Sub LetterOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstNameTxtBox.KeyPress, MiddleNameTxtBox.KeyPress, SurnameTxtBox.KeyPress
        Dim key As String = e.KeyChar
        If (Not Char.IsLetter(key)) Then
            e.Handled = True
        End If
    End Sub

    'Handle only Numbers
    Private Sub NumberOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PhoneNumberTxtBox.KeyPress, AgeTxtBox.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

End Class
