<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Checkout))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstDisplayOrder = New System.Windows.Forms.ListBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnDisplayOrder = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDesserts = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Handwriting", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(330, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 23)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Order Receipt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(306, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 29)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "BOX JB CAFE"
        '
        'lstDisplayOrder
        '
        Me.lstDisplayOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplayOrder.FormattingEnabled = True
        Me.lstDisplayOrder.HorizontalScrollbar = True
        Me.lstDisplayOrder.ItemHeight = 16
        Me.lstDisplayOrder.Location = New System.Drawing.Point(70, 100)
        Me.lstDisplayOrder.Name = "lstDisplayOrder"
        Me.lstDisplayOrder.Size = New System.Drawing.Size(643, 196)
        Me.lstDisplayOrder.TabIndex = 35
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(598, 312)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(116, 42)
        Me.btnConfirm.TabIndex = 36
        Me.btnConfirm.Text = "Confirm Order"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnDisplayOrder
        '
        Me.btnDisplayOrder.Location = New System.Drawing.Point(476, 312)
        Me.btnDisplayOrder.Name = "btnDisplayOrder"
        Me.btnDisplayOrder.Size = New System.Drawing.Size(116, 42)
        Me.btnDisplayOrder.TabIndex = 39
        Me.btnDisplayOrder.Text = "Display Order"
        Me.btnDisplayOrder.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 375)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(810, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'btnDesserts
        '
        Me.btnDesserts.Location = New System.Drawing.Point(70, 312)
        Me.btnDesserts.Name = "btnDesserts"
        Me.btnDesserts.Size = New System.Drawing.Size(136, 42)
        Me.btnDesserts.TabIndex = 40
        Me.btnDesserts.Text = "Back To Desserts"
        Me.btnDesserts.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(354, 312)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(116, 42)
        Me.btnPrint.TabIndex = 41
        Me.btnPrint.Text = "Print As PDF"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDesserts)
        Me.Controls.Add(Me.btnDisplayOrder)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lstDisplayOrder)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Checkout"
        Me.Text = "Checkout"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstDisplayOrder As ListBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDisplayOrder As Button
    Friend WithEvents btnDesserts As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
