Public Class Form1

    'Handle only Letters
    Private Sub LetterOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstNameTxtBox.KeyPress, MiddleNameTxtBox.KeyPress, SurnameTxtBox.KeyPress
        Dim key As String = e.KeyChar
        e.Handled = If((Char.IsLetter(key) Or (Asc(key) = 8)), False, True)
    End Sub

    'Handle only Numbers
    Private Sub NumberOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PhoneNumberTxtBox.KeyPress, AgeTxtBox.KeyPress
        Dim key As String = e.KeyChar
        e.Handled = If((Char.IsDigit(key) Or (Asc(key) = 8)), False, True)
    End Sub

End Class
