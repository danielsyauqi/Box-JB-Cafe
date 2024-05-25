Imports System.Data.OleDb

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\StaffDatabase.accdb")
        Dim cmd As New OleDbCommand("SELECT*FROM StaffTable WHERE Username ='" & txtUsername.Text & "'" & "and Password ='" & txtPassword.Text & "'", conn)


        conn.Open()

        Dim sdr As OleDbDataReader = cmd.ExecuteReader()

        If (sdr.Read() = True) Then
            txtUsername.Text = sdr("Username")
            txtPassword.Text = sdr("Password")
            MessageBox.Show("Login Succesfully!")
            Me.Hide()
            Summary.Show()
        Else
            MessageBox.Show("Invalid Username or Password")
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        MenuForm.Show()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        Registration.Show()
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
