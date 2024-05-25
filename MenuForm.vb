Public Class MenuForm
    Public CustName As String
    Public TableNum As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CustName = txtCustName.Text
        TableNum = Val(txtboxTableNum.Text)
        Me.Hide()
        Beverage.Show()
    End Sub

    Private Sub btnBackLogin_Click(sender As Object, e As EventArgs) Handles btnBackLogin.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub MenuForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class