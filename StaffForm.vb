Imports System.Data.OleDb

Public Class StaffForm
    Private Sub StaffDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffTableBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.StaffDatabaseDataSet)


    End Sub
    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StaffDatabaseDataSet.StaffTable' table. You can move, or remove it, as needed.
        Me.StaffTableTableAdapter.Fill(Me.StaffDatabaseDataSet.StaffTable)
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.StaffTableBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.StaffTableBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.StaffDatabaseDataSet)
        MessageBox.Show("Data has succesfully Saved!")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.StaffTableBindingSource.RemoveCurrent()
        Me.TableAdapterManager1.UpdateAll(Me.StaffDatabaseDataSet)
        MessageBox.Show("Data has been removed!")
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Me.StaffTableBindingSource.MoveFirst()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.StaffTableBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.StaffTableBindingSource.MovePrevious()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Me.StaffTableBindingSource.MoveLast()
    End Sub

    Private Sub btnBackSummary_Click(sender As Object, e As EventArgs) Handles btnBackSummary.Click
        Me.Hide()
        Summary.Show()
    End Sub


    Private Sub StaffForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class