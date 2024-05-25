Public Class Registration

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StaffDatabaseDataSet.StaffTable' table. You can move, or remove it, as needed.
        Me.StaffTableTableAdapter.Fill(Me.StaffDatabaseDataSet.StaffTable)
        Me.StaffTableBindingSource.AddNew()
    End Sub


    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.StaffTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StaffDatabaseDataSet)
        Me.StaffTableBindingSource.AddNew()
        MessageBox.Show("Registration succesful!" & vbNewLine & "p/s: Please contact admin for any inquiries.")
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Registration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class