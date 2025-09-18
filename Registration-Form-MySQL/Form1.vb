Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim ConnectionString As String

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionString = "server=localhost;user=root;database=testdb;port=3306;password=washer22456;"

        'example
        'Dim conn As New MySqlConnection(ConnectionString)
        'Try
        '    conn.Open()
        '    Dim query = "SELECT * FROM `testdb`.`new_table`"
        '    Dim cmd As New MySqlCommand(query, conn)
        '    Dim reader As MySqlDataReader = cmd.ExecuteReader()

        '    While reader.Read
        '        Dim data As String = reader("Name")
        '        MsgBox(data)
        '    End While


        'Catch ex As Exception
        '    MsgBox("Error: " + ex.ToString)
        'End Try
    End Sub
End Class
