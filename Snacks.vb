Public Class Snacks
    Public SandwichPrice, CroissantPrice, MuffinPrice, FrenchFriesPrice, ToastBreadPrice, PastriesPrice As Double

    Public SandwichText, CroissantText, MuffinText, FrenchFriesText, ToastBreadText, PastriesText As String

    Public SandwichQty, CroissantQty, MuffinQty, FrenchFriesQty, ToastBreadQty, PastriesQty As Integer

    Public SandwichPriceNow, CroissantPriceNow, MuffinPriceNow, FrenchFriesPriceNow, ToastBreadPriceNow, PastriesPriceNow As Double

    Public SandwichQtyNow, CroissantQtyNow, MuffinQtyNow, FrenchFriesQtyNow, ToastBreadQtyNow, PastriesQtyNow As Integer

    Public priceSnacks As Double
    Private Sub btnAddToCartSnacks_Click(sender As Object, e As EventArgs) Handles btnAddToCartSnacks.Click
        If chckSandwich.Checked = True Then

            SandwichQtyNow = Val(txtSandwichQty.Text)
            SandwichPriceNow = 5.5 * SandwichQtyNow

            SandwichText = "Sandwich"
            SandwichQty += Val(txtSandwichQty.Text)
            SandwichPrice = 5.5 * SandwichQty

            lstMessage.Items.Add("Snacks Name: " & SandwichText)
            lstMessage.Items.Add("Quantity: " & SandwichQtyNow)
            lstMessage.Items.Add("Base Price: RM" & (SandwichPriceNow / SandwichQtyNow).ToString("N2"))
            lstMessage.Items.Add("Total Sandwich: RM" & SandwichPriceNow.ToString("N2"))
            lstMessage.Items.Add("--------------------------------")
            lstMessage.Items.Add(vbNewLine)

            priceSnacks += SandwichPrice

        End If

        If chckCroissant.Checked = True Then
            CroissantText = "Croissant"

            CroissantQtyNow = Val(txtCroissantQty.Text)
            CroissantPriceNow = 8.0 * CroissantQtyNow

            CroissantQty += Val(txtCroissantQty.Text)
            CroissantPrice = 8.0 * CroissantQty

            lstMessage.Items.Add("Snacks Name: " & CroissantText)
            lstMessage.Items.Add("Quantity: " & CroissantQtyNow)
            lstMessage.Items.Add("Base Price: RM" & (CroissantPriceNow / CroissantQtyNow).ToString("N2"))
            lstMessage.Items.Add("Total Croissant: RM" & CroissantPriceNow.ToString("N2"))
            lstMessage.Items.Add("--------------------------------")
            lstMessage.Items.Add(vbNewLine)

            priceSnacks += CroissantPrice
        End If

        If chckMuffin.Checked = True Then
            MuffinText = "Muffin"

            MuffinQtyNow = Val(txtMuffinQty.Text)
            MuffinPriceNow = 7.5 * MuffinQtyNow

            MuffinQty += Val(txtMuffinQty.Text)
            MuffinPrice = 7.5 * MuffinQty

            lstMessage.Items.Add("Snacks Name: " & MuffinText)
            lstMessage.Items.Add("Quantity: " & MuffinQtyNow)
            lstMessage.Items.Add("Base Price: RM" & (MuffinPriceNow / MuffinQtyNow).ToString("N2"))
            lstMessage.Items.Add("Total Muffin: RM" & MuffinPriceNow.ToString("N2"))
            lstMessage.Items.Add("--------------------------------")
            lstMessage.Items.Add(vbNewLine)

            priceSnacks += MuffinPrice
        Else
            txtMuffinQty.ReadOnly = True
            txtMuffinQty.Clear()
        End If

        If chckFries.Checked = True Then
            FrenchFriesText = "French Fries"

            FrenchFriesQtyNow = Val(txtFriesQty.Text)
            FrenchFriesPriceNow = 6.7 * FrenchFriesQtyNow

            FrenchFriesQty += Val(txtFriesQty.Text)
            FrenchFriesPrice = 6.7 * FrenchFriesQty

            lstMessage.Items.Add("Snacks Name: " & FrenchFriesText)
            lstMessage.Items.Add("Quantity: " & FrenchFriesQtyNow)
            lstMessage.Items.Add("Base Price: RM" & (FrenchFriesPriceNow / FrenchFriesQtyNow).ToString("N2"))
            lstMessage.Items.Add("Total French Fries: RM" & FrenchFriesPriceNow.ToString("N2"))
            lstMessage.Items.Add("--------------------------------")
            lstMessage.Items.Add(vbNewLine)

            priceSnacks += FrenchFriesPrice

        End If

        If chckBread.Checked = True Then
            ToastBreadText = "Toast Bread"

            ToastBreadQtyNow = Val(txtBreadQty.Text)
            ToastBreadPriceNow = 4.9 * ToastBreadQtyNow

            ToastBreadQty += Val(txtBreadQty.Text)
            ToastBreadPrice = 4.9 * ToastBreadQty

            lstMessage.Items.Add("Snacks Name: " & ToastBreadText)
            lstMessage.Items.Add("Quantity: " & ToastBreadQtyNow)
            lstMessage.Items.Add("Base Price: RM" & (ToastBreadPriceNow / ToastBreadQtyNow).ToString("N2"))
            lstMessage.Items.Add("Total Toast Bread: RM" & ToastBreadPriceNow.ToString("N2"))
            lstMessage.Items.Add("--------------------------------")
            lstMessage.Items.Add(vbNewLine)

            priceSnacks += ToastBreadPrice
        End If

        If chckPastry.Checked = True Then
            PastriesText = "Pastries"

            PastriesQtyNow = Val(txtPastriesQty.Text)
            PastriesPriceNow = 8.9 * PastriesQtyNow

            PastriesQty += Val(txtPastriesQty.Text)
            PastriesPrice = 8.9 * PastriesQty

            lstMessage.Items.Add("Snacks Name: " & PastriesText)
            lstMessage.Items.Add("Quantity: " & PastriesQtyNow)
            lstMessage.Items.Add("Base Price: RM" & (PastriesPriceNow / PastriesQtyNow).ToString("N2"))
            lstMessage.Items.Add("Total Pastries: RM" & PastriesPriceNow.ToString("N2"))
            lstMessage.Items.Add("--------------------------------")
            lstMessage.Items.Add(vbNewLine)

        End If

    End Sub


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Beverage.Show()
    End Sub

    Private Sub btnSnacks_Click(sender As Object, e As EventArgs) Handles btnSnacks.Click
        Me.Hide()
        Desserts.Show()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Me.Hide()
        Checkout.Show()
    End Sub

    Private Sub btnSandwichAbout_Click(sender As Object, e As EventArgs) Handles btnSandwichAbout.Click
        lblAboutSnacks.Text = "Layers of roasted turkey, crispy bacon, lettuce, tomato, and mayo nestled between three slices of toasted whole wheat bread. Served with a side of golden fries or a fresh garden salad."

        picCroissant.Visible = False
        picFries.Visible = False
        picMuffin.Visible = False
        picPastries.Visible = False
        picSandwich.Visible = True
        picToastBread.Visible = False

    End Sub
    Private Sub btnCroissantAbout_Click(sender As Object, e As EventArgs) Handles btnCroissantAbout.Click
        lblAboutSnacks.Text = "Indulge in the simplicity of a flaky, buttery croissant, freshly baked to golden perfection. A delightful treat perfect for any time of day."

        picCroissant.Visible = True
        picFries.Visible = False
        picMuffin.Visible = False
        picPastries.Visible = False
        picSandwich.Visible = False
        picToastBread.Visible = False

    End Sub
    Private Sub btnMuffinAbout_Click(sender As Object, e As EventArgs) Handles btnMuffinAbout.Click
        lblAboutSnacks.Text = "Double Chocolate Delight Rich, cocoa-infused muffins packed with chocolate chips, offering an indulgent treat for chocolate lovers."

        picCroissant.Visible = False
        picFries.Visible = False
        picMuffin.Visible = True
        picPastries.Visible = False
        picSandwich.Visible = False
        picToastBread.Visible = False

    End Sub
    Private Sub btnFriesAbout_Click(sender As Object, e As EventArgs) Handles btnFriesAbout.Click
        lblAboutSnacks.Text = "Our classic fries are a crispy delight. Hand-cut from top-notch potatoes, they're fried to golden perfection and lightly seasoned for that familiar, delicious taste. Ideal with any dish or as a standalone treat, these fries offer the perfect crunch and fluffy interior, making every bite a pure satisfaction."

        picCroissant.Visible = False
        picFries.Visible = True
        picMuffin.Visible = False
        picPastries.Visible = False
        picSandwich.Visible = False
        picToastBread.Visible = False

    End Sub
    Private Sub btnBreadAbout_Click(sender As Object, e As EventArgs) Handles btnBreadAbout.Click
        lblAboutSnacks.Text = "Our classic toasted bread: golden, crispy, and comforting. With its warm crunch and soft center, it's the perfect canvas for your favorite toppings or a delightful standalone snack."

        picCroissant.Visible = False
        picFries.Visible = False
        picMuffin.Visible = False
        picPastries.Visible = False
        picSandwich.Visible = False
        picToastBread.Visible = True

    End Sub
    Private Sub btnPastriesAbout_Click(sender As Object, e As EventArgs) Handles btnPastriesAbout.Click
        lblAboutSnacks.Text = "Experience an array of delightful pastries, each crafted to tantalize your taste buds with layers of flakiness, rich chocolatey goodness, fruity bursts, and buttery perfection—all in a single, tempting assortment."

        picCroissant.Visible = False
        picFries.Visible = False
        picMuffin.Visible = False
        picPastries.Visible = True
        picSandwich.Visible = False
        picToastBread.Visible = False

    End Sub

    Private Sub chckSandwich_CheckedChanged(sender As Object, e As EventArgs) Handles chckSandwich.CheckedChanged
        If chckSandwich.Checked = True Then
            txtSandwichQty.ReadOnly = False
        Else
            txtSandwichQty.ReadOnly = True
            txtSandwichQty.Clear()
        End If
    End Sub

    Private Sub chckCroissant_CheckedChanged(sender As Object, e As EventArgs) Handles chckCroissant.CheckedChanged
        If chckCroissant.Checked = True Then
            txtCroissantQty.ReadOnly = False
        Else
            txtCroissantQty.ReadOnly = True
            txtCroissantQty.Clear()
        End If
    End Sub

    Private Sub chckMuffin_CheckedChanged(sender As Object, e As EventArgs) Handles chckMuffin.CheckedChanged
        If chckMuffin.Checked = True Then
            txtMuffinQty.ReadOnly = False
        Else
            txtMuffinQty.ReadOnly = True
            txtMuffinQty.Clear()
        End If
    End Sub

    Private Sub chckFries_CheckedChanged(sender As Object, e As EventArgs) Handles chckFries.CheckedChanged
        If chckFries.Checked = True Then
            txtFriesQty.ReadOnly = False
        Else
            txtFriesQty.ReadOnly = True
            txtFriesQty.Clear()
        End If
    End Sub

    Private Sub chckBread_CheckedChanged(sender As Object, e As EventArgs) Handles chckBread.CheckedChanged
        If chckBread.Checked = True Then
            txtBreadQty.ReadOnly = False
        Else
            txtBreadQty.ReadOnly = True
            txtBreadQty.Clear()
        End If
    End Sub

    Private Sub chckPastry_CheckedChanged(sender As Object, e As EventArgs) Handles chckPastry.CheckedChanged
        If chckPastry.Checked = True Then
            txtPastriesQty.ReadOnly = False
        Else
            txtPastriesQty.ReadOnly = True
            txtPastriesQty.Clear()
        End If
    End Sub


    Private Sub Snacks_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class