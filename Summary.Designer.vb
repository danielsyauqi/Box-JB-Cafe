<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Summary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Summary))
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lstDisplaySummary = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.StaffTable = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(598, 306)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(116, 42)
        Me.btnHome.TabIndex = 43
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(476, 306)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 42)
        Me.btnReset.TabIndex = 42
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lstDisplaySummary
        '
        Me.lstDisplaySummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lstDisplaySummary.FormattingEnabled = True
        Me.lstDisplaySummary.HorizontalScrollbar = True
        Me.lstDisplaySummary.ItemHeight = 18
        Me.lstDisplaySummary.Location = New System.Drawing.Point(71, 98)
        Me.lstDisplaySummary.Name = "lstDisplaySummary"
        Me.lstDisplaySummary.Size = New System.Drawing.Size(643, 202)
        Me.lstDisplaySummary.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Handwriting", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(316, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 23)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Summary Sales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(307, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 29)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "BOX JB CAFE"
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(310, 306)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(160, 42)
        Me.btnSummary.TabIndex = 45
        Me.btnSummary.Text = "Display Summary"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'StaffTable
        '
        Me.StaffTable.Location = New System.Drawing.Point(71, 306)
        Me.StaffTable.Name = "StaffTable"
        Me.StaffTable.Size = New System.Drawing.Size(156, 42)
        Me.StaffTable.TabIndex = 46
        Me.StaffTable.Text = "Go To Staff Table"
        Me.StaffTable.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 373)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(810, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StaffTable)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lstDisplaySummary)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Summary"
        Me.Text = "Summary"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lstDisplaySummary As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSummary As Button
    Friend WithEvents StaffTable As Button
End Class
