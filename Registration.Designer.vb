<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim StaffNameLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picRegister = New System.Windows.Forms.PictureBox()
        Me.StaffDatabaseDataSet = New BoxJBCafe.StaffDatabaseDataSet()
        Me.StaffTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableTableAdapter = New BoxJBCafe.StaffDatabaseDataSetTableAdapters.StaffTableTableAdapter()
        Me.TableAdapterManager = New BoxJBCafe.StaffDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.IDLabel1 = New System.Windows.Forms.Label()
        Me.StaffNameTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        StaffNameLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        CType(Me.picRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(89, 121)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(23, 16)
        IDLabel.TabIndex = 17
        IDLabel.Text = "ID:"
        '
        'StaffNameLabel
        '
        StaffNameLabel.AutoSize = True
        StaffNameLabel.Location = New System.Drawing.Point(36, 170)
        StaffNameLabel.Name = "StaffNameLabel"
        StaffNameLabel.Size = New System.Drawing.Size(76, 16)
        StaffNameLabel.TabIndex = 18
        StaffNameLabel.Text = "Staff Name:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(39, 228)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(73, 16)
        UsernameLabel.TabIndex = 19
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(42, 291)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(70, 16)
        PasswordLabel.TabIndex = 20
        PasswordLabel.Text = "Password:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(54, 354)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(58, 16)
        PositionLabel.TabIndex = 21
        PositionLabel.Text = "Position:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Handwriting", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Registration Page"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 29)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "BOX JB CAFE"
        '
        'picRegister
        '
        Me.picRegister.ErrorImage = Global.BoxJBCafe.My.Resources.Resources.login_background
        Me.picRegister.Image = Global.BoxJBCafe.My.Resources.Resources.login_background
        Me.picRegister.ImageLocation = ""
        Me.picRegister.InitialImage = Global.BoxJBCafe.My.Resources.Resources.login_background
        Me.picRegister.Location = New System.Drawing.Point(437, -4)
        Me.picRegister.Name = "picRegister"
        Me.picRegister.Size = New System.Drawing.Size(425, 701)
        Me.picRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picRegister.TabIndex = 10
        Me.picRegister.TabStop = False
        '
        'StaffDatabaseDataSet
        '
        Me.StaffDatabaseDataSet.DataSetName = "StaffDatabaseDataSet"
        Me.StaffDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffTableBindingSource
        '
        Me.StaffTableBindingSource.DataMember = "StaffTable"
        Me.StaffTableBindingSource.DataSource = Me.StaffDatabaseDataSet
        '
        'StaffTableTableAdapter
        '
        Me.StaffTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StaffTableTableAdapter = Me.StaffTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = BoxJBCafe.StaffDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDLabel1
        '
        Me.IDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IDLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffTableBindingSource, "ID", True))
        Me.IDLabel1.Location = New System.Drawing.Point(118, 120)
        Me.IDLabel1.Name = "IDLabel1"
        Me.IDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IDLabel1.TabIndex = 18
        Me.IDLabel1.Text = "Label1"
        '
        'StaffNameTextBox
        '
        Me.StaffNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffTableBindingSource, "StaffName", True))
        Me.StaffNameTextBox.Location = New System.Drawing.Point(118, 167)
        Me.StaffNameTextBox.Name = "StaffNameTextBox"
        Me.StaffNameTextBox.Size = New System.Drawing.Size(279, 22)
        Me.StaffNameTextBox.TabIndex = 19
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffTableBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(118, 225)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(279, 22)
        Me.UsernameTextBox.TabIndex = 20
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffTableBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(118, 288)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(279, 22)
        Me.PasswordTextBox.TabIndex = 21
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffTableBindingSource, "Position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(118, 351)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(279, 22)
        Me.PositionTextBox.TabIndex = 22
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(100, 457)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(184, 47)
        Me.btnConfirm.TabIndex = 23
        Me.btnConfirm.Text = "Confirm Registration"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 687)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(StaffNameLabel)
        Me.Controls.Add(Me.StaffNameTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDLabel1)
        Me.Controls.Add(Me.picRegister)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Registration"
        Me.Text = "Registration"
        CType(Me.picRegister, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picRegister As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents StaffDatabaseDataSet As StaffDatabaseDataSet
    Friend WithEvents StaffTableBindingSource As BindingSource
    Friend WithEvents StaffTableTableAdapter As StaffDatabaseDataSetTableAdapters.StaffTableTableAdapter
    Friend WithEvents TableAdapterManager As StaffDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDLabel1 As Label
    Friend WithEvents StaffNameTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents btnConfirm As Button
End Class
