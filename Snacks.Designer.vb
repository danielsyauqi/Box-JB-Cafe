<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Snacks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Snacks))
        Me.btnSnacks = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblAboutSnacks = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chckSandwich = New System.Windows.Forms.CheckBox()
        Me.chckCroissant = New System.Windows.Forms.CheckBox()
        Me.chckMuffin = New System.Windows.Forms.CheckBox()
        Me.chckFries = New System.Windows.Forms.CheckBox()
        Me.txtSandwichQty = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCroissantQty = New System.Windows.Forms.TextBox()
        Me.txtMuffinQty = New System.Windows.Forms.TextBox()
        Me.txtFriesQty = New System.Windows.Forms.TextBox()
        Me.btnSandwichAbout = New System.Windows.Forms.Button()
        Me.btnCroissantAbout = New System.Windows.Forms.Button()
        Me.btnMuffinAbout = New System.Windows.Forms.Button()
        Me.btnFriesAbout = New System.Windows.Forms.Button()
        Me.chckBread = New System.Windows.Forms.CheckBox()
        Me.txtBreadQty = New System.Windows.Forms.TextBox()
        Me.btnBreadAbout = New System.Windows.Forms.Button()
        Me.chckPastry = New System.Windows.Forms.CheckBox()
        Me.txtPastriesQty = New System.Windows.Forms.TextBox()
        Me.btnPastriesAbout = New System.Windows.Forms.Button()
        Me.gpFrappe = New System.Windows.Forms.GroupBox()
        Me.btnAddToCartSnacks = New System.Windows.Forms.Button()
        Me.lstMessage = New System.Windows.Forms.ListBox()
        Me.picPastries = New System.Windows.Forms.PictureBox()
        Me.picToastBread = New System.Windows.Forms.PictureBox()
        Me.picFries = New System.Windows.Forms.PictureBox()
        Me.picMuffin = New System.Windows.Forms.PictureBox()
        Me.picCroissant = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picSandwich = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.gpFrappe.SuspendLayout()
        CType(Me.picPastries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picToastBread, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMuffin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCroissant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSandwich, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSnacks
        '
        Me.btnSnacks.Location = New System.Drawing.Point(198, 385)
        Me.btnSnacks.Name = "btnSnacks"
        Me.btnSnacks.Size = New System.Drawing.Size(137, 34)
        Me.btnSnacks.TabIndex = 29
        Me.btnSnacks.Text = "Go To Desserts"
        Me.btnSnacks.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(20, 385)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(172, 34)
        Me.btnHome.TabIndex = 28
        Me.btnHome.Text = "Back To Beverages"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New System.Drawing.Point(341, 385)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(136, 34)
        Me.btnCheckout.TabIndex = 25
        Me.btnCheckout.Text = "Go To Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblAboutSnacks)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(505, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 196)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "About:"
        '
        'lblAboutSnacks
        '
        Me.lblAboutSnacks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutSnacks.Location = New System.Drawing.Point(15, 33)
        Me.lblAboutSnacks.Name = "lblAboutSnacks"
        Me.lblAboutSnacks.Size = New System.Drawing.Size(269, 150)
        Me.lblAboutSnacks.TabIndex = 0
        Me.lblAboutSnacks.Text = "Text appear here"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Handwriting", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Snacks Selection Page"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 29)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "BOX JB CAFE"
        '
        'chckSandwich
        '
        Me.chckSandwich.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chckSandwich.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.chckSandwich.Location = New System.Drawing.Point(6, 51)
        Me.chckSandwich.Name = "chckSandwich"
        Me.chckSandwich.Size = New System.Drawing.Size(205, 20)
        Me.chckSandwich.TabIndex = 0
        Me.chckSandwich.Text = "Sandwich"
        Me.chckSandwich.UseVisualStyleBackColor = True
        '
        'chckCroissant
        '
        Me.chckCroissant.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chckCroissant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.chckCroissant.Location = New System.Drawing.Point(6, 78)
        Me.chckCroissant.Name = "chckCroissant"
        Me.chckCroissant.Size = New System.Drawing.Size(205, 21)
        Me.chckCroissant.TabIndex = 1
        Me.chckCroissant.Text = "Croissant"
        Me.chckCroissant.UseVisualStyleBackColor = True
        '
        'chckMuffin
        '
        Me.chckMuffin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chckMuffin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.chckMuffin.Location = New System.Drawing.Point(6, 105)
        Me.chckMuffin.Name = "chckMuffin"
        Me.chckMuffin.Size = New System.Drawing.Size(205, 21)
        Me.chckMuffin.TabIndex = 2
        Me.chckMuffin.Text = "Muffin"
        Me.chckMuffin.UseVisualStyleBackColor = True
        '
        'chckFries
        '
        Me.chckFries.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chckFries.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.chckFries.Location = New System.Drawing.Point(6, 132)
        Me.chckFries.Name = "chckFries"
        Me.chckFries.Size = New System.Drawing.Size(205, 21)
        Me.chckFries.TabIndex = 3
        Me.chckFries.Text = "French Fries"
        Me.chckFries.UseVisualStyleBackColor = True
        '
        'txtSandwichQty
        '
        Me.txtSandwichQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSandwichQty.Location = New System.Drawing.Point(222, 47)
        Me.txtSandwichQty.Name = "txtSandwichQty"
        Me.txtSandwichQty.ReadOnly = True
        Me.txtSandwichQty.Size = New System.Drawing.Size(56, 22)
        Me.txtSandwichQty.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(223, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 16)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Quantity"
        '
        'txtCroissantQty
        '
        Me.txtCroissantQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCroissantQty.Location = New System.Drawing.Point(222, 75)
        Me.txtCroissantQty.Name = "txtCroissantQty"
        Me.txtCroissantQty.ReadOnly = True
        Me.txtCroissantQty.Size = New System.Drawing.Size(56, 22)
        Me.txtCroissantQty.TabIndex = 6
        '
        'txtMuffinQty
        '
        Me.txtMuffinQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMuffinQty.Location = New System.Drawing.Point(222, 102)
        Me.txtMuffinQty.Name = "txtMuffinQty"
        Me.txtMuffinQty.ReadOnly = True
        Me.txtMuffinQty.Size = New System.Drawing.Size(56, 22)
        Me.txtMuffinQty.TabIndex = 8
        '
        'txtFriesQty
        '
        Me.txtFriesQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFriesQty.Location = New System.Drawing.Point(222, 128)
        Me.txtFriesQty.Name = "txtFriesQty"
        Me.txtFriesQty.ReadOnly = True
        Me.txtFriesQty.Size = New System.Drawing.Size(56, 22)
        Me.txtFriesQty.TabIndex = 10
        '
        'btnSandwichAbout
        '
        Me.btnSandwichAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.btnSandwichAbout.Location = New System.Drawing.Point(294, 48)
        Me.btnSandwichAbout.Name = "btnSandwichAbout"
        Me.btnSandwichAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnSandwichAbout.TabIndex = 11
        Me.btnSandwichAbout.Text = "About"
        Me.btnSandwichAbout.UseVisualStyleBackColor = True
        '
        'btnCroissantAbout
        '
        Me.btnCroissantAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.btnCroissantAbout.Location = New System.Drawing.Point(294, 76)
        Me.btnCroissantAbout.Name = "btnCroissantAbout"
        Me.btnCroissantAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnCroissantAbout.TabIndex = 12
        Me.btnCroissantAbout.Text = "About"
        Me.btnCroissantAbout.UseVisualStyleBackColor = True
        '
        'btnMuffinAbout
        '
        Me.btnMuffinAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.btnMuffinAbout.Location = New System.Drawing.Point(294, 102)
        Me.btnMuffinAbout.Name = "btnMuffinAbout"
        Me.btnMuffinAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnMuffinAbout.TabIndex = 13
        Me.btnMuffinAbout.Text = "About"
        Me.btnMuffinAbout.UseVisualStyleBackColor = True
        '
        'btnFriesAbout
        '
        Me.btnFriesAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.btnFriesAbout.Location = New System.Drawing.Point(294, 129)
        Me.btnFriesAbout.Name = "btnFriesAbout"
        Me.btnFriesAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnFriesAbout.TabIndex = 14
        Me.btnFriesAbout.Text = "About"
        Me.btnFriesAbout.UseVisualStyleBackColor = True
        '
        'chckBread
        '
        Me.chckBread.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chckBread.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.chckBread.Location = New System.Drawing.Point(6, 158)
        Me.chckBread.Name = "chckBread"
        Me.chckBread.Size = New System.Drawing.Size(205, 21)
        Me.chckBread.TabIndex = 15
        Me.chckBread.Text = "Toast Bread"
        Me.chckBread.UseVisualStyleBackColor = True
        '
        'txtBreadQty
        '
        Me.txtBreadQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBreadQty.Location = New System.Drawing.Point(222, 155)
        Me.txtBreadQty.Name = "txtBreadQty"
        Me.txtBreadQty.ReadOnly = True
        Me.txtBreadQty.Size = New System.Drawing.Size(56, 22)
        Me.txtBreadQty.TabIndex = 16
        '
        'btnBreadAbout
        '
        Me.btnBreadAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.btnBreadAbout.Location = New System.Drawing.Point(294, 156)
        Me.btnBreadAbout.Name = "btnBreadAbout"
        Me.btnBreadAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnBreadAbout.TabIndex = 18
        Me.btnBreadAbout.Text = "About"
        Me.btnBreadAbout.UseVisualStyleBackColor = True
        '
        'chckPastry
        '
        Me.chckPastry.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chckPastry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.chckPastry.Location = New System.Drawing.Point(6, 183)
        Me.chckPastry.Name = "chckPastry"
        Me.chckPastry.Size = New System.Drawing.Size(205, 21)
        Me.chckPastry.TabIndex = 19
        Me.chckPastry.Text = "Pastries"
        Me.chckPastry.UseVisualStyleBackColor = True
        '
        'txtPastriesQty
        '
        Me.txtPastriesQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPastriesQty.Location = New System.Drawing.Point(222, 183)
        Me.txtPastriesQty.Name = "txtPastriesQty"
        Me.txtPastriesQty.ReadOnly = True
        Me.txtPastriesQty.Size = New System.Drawing.Size(56, 22)
        Me.txtPastriesQty.TabIndex = 20
        '
        'btnPastriesAbout
        '
        Me.btnPastriesAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.btnPastriesAbout.Location = New System.Drawing.Point(294, 184)
        Me.btnPastriesAbout.Name = "btnPastriesAbout"
        Me.btnPastriesAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnPastriesAbout.TabIndex = 22
        Me.btnPastriesAbout.Text = "About"
        Me.btnPastriesAbout.UseVisualStyleBackColor = True
        '
        'gpFrappe
        '
        Me.gpFrappe.Controls.Add(Me.btnPastriesAbout)
        Me.gpFrappe.Controls.Add(Me.txtPastriesQty)
        Me.gpFrappe.Controls.Add(Me.chckPastry)
        Me.gpFrappe.Controls.Add(Me.btnBreadAbout)
        Me.gpFrappe.Controls.Add(Me.txtBreadQty)
        Me.gpFrappe.Controls.Add(Me.chckBread)
        Me.gpFrappe.Controls.Add(Me.btnFriesAbout)
        Me.gpFrappe.Controls.Add(Me.btnMuffinAbout)
        Me.gpFrappe.Controls.Add(Me.btnCroissantAbout)
        Me.gpFrappe.Controls.Add(Me.btnSandwichAbout)
        Me.gpFrappe.Controls.Add(Me.txtFriesQty)
        Me.gpFrappe.Controls.Add(Me.txtMuffinQty)
        Me.gpFrappe.Controls.Add(Me.txtCroissantQty)
        Me.gpFrappe.Controls.Add(Me.Label15)
        Me.gpFrappe.Controls.Add(Me.txtSandwichQty)
        Me.gpFrappe.Controls.Add(Me.chckFries)
        Me.gpFrappe.Controls.Add(Me.chckMuffin)
        Me.gpFrappe.Controls.Add(Me.chckCroissant)
        Me.gpFrappe.Controls.Add(Me.chckSandwich)
        Me.gpFrappe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpFrappe.Location = New System.Drawing.Point(20, 87)
        Me.gpFrappe.Name = "gpFrappe"
        Me.gpFrappe.Size = New System.Drawing.Size(457, 236)
        Me.gpFrappe.TabIndex = 27
        Me.gpFrappe.TabStop = False
        Me.gpFrappe.Text = "Snacks Menu:"
        '
        'btnAddToCartSnacks
        '
        Me.btnAddToCartSnacks.Location = New System.Drawing.Point(20, 329)
        Me.btnAddToCartSnacks.Name = "btnAddToCartSnacks"
        Me.btnAddToCartSnacks.Size = New System.Drawing.Size(457, 50)
        Me.btnAddToCartSnacks.TabIndex = 31
        Me.btnAddToCartSnacks.Text = "Add To Cart"
        Me.btnAddToCartSnacks.UseVisualStyleBackColor = True
        '
        'lstMessage
        '
        Me.lstMessage.FormattingEnabled = True
        Me.lstMessage.HorizontalScrollbar = True
        Me.lstMessage.ItemHeight = 16
        Me.lstMessage.Location = New System.Drawing.Point(505, 306)
        Me.lstMessage.Name = "lstMessage"
        Me.lstMessage.Size = New System.Drawing.Size(592, 132)
        Me.lstMessage.TabIndex = 32
        '
        'picPastries
        '
        Me.picPastries.Image = Global.BoxJBCafe.My.Resources.Resources.pastries
        Me.picPastries.Location = New System.Drawing.Point(827, 100)
        Me.picPastries.Name = "picPastries"
        Me.picPastries.Size = New System.Drawing.Size(270, 192)
        Me.picPastries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPastries.TabIndex = 37
        Me.picPastries.TabStop = False
        Me.picPastries.Visible = False
        '
        'picToastBread
        '
        Me.picToastBread.Image = Global.BoxJBCafe.My.Resources.Resources.bread
        Me.picToastBread.Location = New System.Drawing.Point(827, 99)
        Me.picToastBread.Name = "picToastBread"
        Me.picToastBread.Size = New System.Drawing.Size(270, 192)
        Me.picToastBread.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picToastBread.TabIndex = 36
        Me.picToastBread.TabStop = False
        Me.picToastBread.Visible = False
        '
        'picFries
        '
        Me.picFries.Image = Global.BoxJBCafe.My.Resources.Resources.fries
        Me.picFries.Location = New System.Drawing.Point(827, 99)
        Me.picFries.Name = "picFries"
        Me.picFries.Size = New System.Drawing.Size(270, 192)
        Me.picFries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFries.TabIndex = 35
        Me.picFries.TabStop = False
        Me.picFries.Visible = False
        '
        'picMuffin
        '
        Me.picMuffin.Image = Global.BoxJBCafe.My.Resources.Resources.muffin
        Me.picMuffin.Location = New System.Drawing.Point(827, 100)
        Me.picMuffin.Name = "picMuffin"
        Me.picMuffin.Size = New System.Drawing.Size(270, 192)
        Me.picMuffin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMuffin.TabIndex = 34
        Me.picMuffin.TabStop = False
        Me.picMuffin.Visible = False
        '
        'picCroissant
        '
        Me.picCroissant.Image = Global.BoxJBCafe.My.Resources.Resources.croissant
        Me.picCroissant.Location = New System.Drawing.Point(827, 99)
        Me.picCroissant.Name = "picCroissant"
        Me.picCroissant.Size = New System.Drawing.Size(270, 192)
        Me.picCroissant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCroissant.TabIndex = 33
        Me.picCroissant.TabStop = False
        Me.picCroissant.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(330, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(783, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'picSandwich
        '
        Me.picSandwich.Image = Global.BoxJBCafe.My.Resources.Resources.sandwich
        Me.picSandwich.Location = New System.Drawing.Point(827, 99)
        Me.picSandwich.Name = "picSandwich"
        Me.picSandwich.Size = New System.Drawing.Size(270, 192)
        Me.picSandwich.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSandwich.TabIndex = 23
        Me.picSandwich.TabStop = False
        Me.picSandwich.Visible = False
        '
        'Snacks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 450)
        Me.Controls.Add(Me.picPastries)
        Me.Controls.Add(Me.picToastBread)
        Me.Controls.Add(Me.picFries)
        Me.Controls.Add(Me.picMuffin)
        Me.Controls.Add(Me.picCroissant)
        Me.Controls.Add(Me.lstMessage)
        Me.Controls.Add(Me.btnAddToCartSnacks)
        Me.Controls.Add(Me.gpFrappe)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSnacks)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.picSandwich)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Snacks"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.gpFrappe.ResumeLayout(False)
        Me.gpFrappe.PerformLayout()
        CType(Me.picPastries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picToastBread, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMuffin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCroissant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSandwich, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSnacks As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblAboutSnacks As Label
    Friend WithEvents picSandwich As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chckSandwich As CheckBox
    Friend WithEvents chckCroissant As CheckBox
    Friend WithEvents chckMuffin As CheckBox
    Friend WithEvents chckFries As CheckBox
    Friend WithEvents txtSandwichQty As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCroissantQty As TextBox
    Friend WithEvents txtMuffinQty As TextBox
    Friend WithEvents txtFriesQty As TextBox
    Friend WithEvents btnSandwichAbout As Button
    Friend WithEvents btnCroissantAbout As Button
    Friend WithEvents btnMuffinAbout As Button
    Friend WithEvents btnFriesAbout As Button
    Friend WithEvents chckBread As CheckBox
    Friend WithEvents txtBreadQty As TextBox
    Friend WithEvents btnBreadAbout As Button
    Friend WithEvents chckPastry As CheckBox
    Friend WithEvents txtPastriesQty As TextBox
    Friend WithEvents btnPastriesAbout As Button
    Friend WithEvents gpFrappe As GroupBox
    Friend WithEvents btnAddToCartSnacks As Button
    Friend WithEvents lstMessage As ListBox
    Friend WithEvents picCroissant As PictureBox
    Friend WithEvents picMuffin As PictureBox
    Friend WithEvents picFries As PictureBox
    Friend WithEvents picToastBread As PictureBox
    Friend WithEvents picPastries As PictureBox
End Class
