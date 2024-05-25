<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim StaffNameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffForm))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBackSummary = New System.Windows.Forms.Button()
        Me.StaffDatabaseDataSet = New BoxJBCafe.StaffDatabaseDataSet()
        Me.StaffTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableTableAdapter = New BoxJBCafe.StaffDatabaseDataSetTableAdapters.StaffTableTableAdapter()
        Me.TableAdapterManager1 = New BoxJBCafe.StaffDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.StaffTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDLabel1 = New System.Windows.Forms.Label()
        Me.StaffNameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        StaffNameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(130, 425)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(23, 16)
        IDLabel.TabIndex = 59
        IDLabel.Text = "ID:"
        '
        'StaffNameLabel
        '
        StaffNameLabel.AutoSize = True
        StaffNameLabel.Location = New System.Drawing.Point(77, 450)
        StaffNameLabel.Name = "StaffNameLabel"
        StaffNameLabel.Size = New System.Drawing.Size(76, 16)
        StaffNameLabel.TabIndex = 60
        StaffNameLabel.Text = "Staff Name:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(83, 509)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(70, 16)
        PasswordLabel.TabIndex = 61
        PasswordLabel.Text = "Password:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(80, 478)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(73, 16)
        UsernameLabel.TabIndex = 62
        UsernameLabel.Text = "Username:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(95, 537)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(58, 16)
        PositionLabel.TabIndex = 63
        PositionLabel.Text = "Position:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Handwriting", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(344, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 23)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Staff Table"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(305, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 29)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "BOX JB CAFE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 636)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1142, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(945, 310)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(106, 41)
        Me.btnPrevious.TabIndex = 57
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(945, 263)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(106, 41)
        Me.btnLast.TabIndex = 56
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(833, 310)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(106, 41)
        Me.btnNext.TabIndex = 55
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(833, 263)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(106, 41)
        Me.btnFirst.TabIndex = 54
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(945, 169)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 41)
        Me.btnExit.TabIndex = 53
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(833, 216)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(218, 41)
        Me.btnDelete.TabIndex = 51
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(833, 357)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(218, 41)
        Me.btnSave.TabIndex = 50
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(833, 169)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(106, 41)
        Me.btnAdd.TabIndex = 49
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBackSummary
        '
        Me.btnBackSummary.Location = New System.Drawing.Point(833, 122)
        Me.btnBackSummary.Name = "btnBackSummary"
        Me.btnBackSummary.Size = New System.Drawing.Size(218, 41)
        Me.btnBackSummary.TabIndex = 58
        Me.btnBackSummary.Text = "Back to Summary "
        Me.btnBackSummary.UseVisualStyleBackColor = True
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.StaffTableTableAdapter = Me.StaffTableTableAdapter
        Me.TableAdapterManager1.UpdateOrder = BoxJBCafe.StaffDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StaffTableDataGridView
        '
        Me.StaffTableDataGridView.AutoGenerateColumns = False
        Me.StaffTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.StaffTableDataGridView.DataSource = Me.StaffTableBindingSource
        Me.StaffTableDataGridView.Location = New System.Drawing.Point(59, 122)
        Me.StaffTableDataGridView.Name = "StaffTableDataGridView"
        Me.StaffTableDataGridView.RowHeadersWidth = 51
        Me.StaffTableDataGridView.RowTemplate.Height = 24
        Me.StaffTableDataGridView.Size = New System.Drawing.Size(704, 229)
        Me.StaffTableDataGridView.TabIndex = 59
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "StaffName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "StaffName"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Position"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Position"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'IDLabel1
        '
        Me.IDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffTableBindingSource, "ID", True))
        Me.IDLabel1.Location = New System.Drawing.Point(159, 424)
        Me.IDLabel1.Name = "IDLabel1"
        Me.IDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IDLabel1.TabIndex = 60
        Me.IDLabel1.Text = "Label1"
        '
        'StaffNameTextBox
        '
        Me.StaffNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffTableBindingSource, "StaffName", True))
        Me.StaffNameTextBox.Location = New System.Drawing.Point(159, 450)
        Me.StaffNameTextBox.Name = "StaffNameTextBox"
        Me.StaffNameTextBox.Size = New System.Drawing.Size(349, 22)
        Me.StaffNameTextBox.TabIndex = 61
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffTableBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(159, 506)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(295, 22)
        Me.PasswordTextBox.TabIndex = 62
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffTableBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(159, 478)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(295, 22)
        Me.UsernameTextBox.TabIndex = 63
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffTableBindingSource, "Position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(159, 534)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(295, 22)
        Me.PositionTextBox.TabIndex = 64
        '
        'StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 765)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(StaffNameLabel)
        Me.Controls.Add(Me.StaffNameTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDLabel1)
        Me.Controls.Add(Me.StaffTableDataGridView)
        Me.Controls.Add(Me.btnBackSummary)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "StaffForm"
        Me.Text = "StaffForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBackSummary As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents StaffDatabaseDataSet As StaffDatabaseDataSet
    Friend WithEvents StaffTableBindingSource As BindingSource
    Friend WithEvents StaffTableTableAdapter As StaffDatabaseDataSetTableAdapters.StaffTableTableAdapter
    Friend WithEvents TableAdapterManager1 As StaffDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffTableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents IDLabel1 As Label
    Friend WithEvents StaffNameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
End Class
