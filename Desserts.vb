Public Class Desserts
    Public CarrotCakeText, MoltenCakeText, BananaCakeText, TiramisuCakeText, PancakeText, ApplePieText As String
    Public CarrotCakePrice, MoltenCakePrice, BananaCakePrice, TiramisuCakePrice, PancakePrice, ApplePiePrice As Double
    Public CarrotCakeQty, MoltenCakeQty, BananaCakeQty, TiramisuCakeQty, PancakeQty, ApplePieQty As Integer

    Public CarrotCakePriceNow, MoltenCakePriceNow, BananaCakePriceNow, TiramisuCakePriceNow, PancakePriceNow, ApplePiePriceNow As Double

    Public CarrotCakeQtyNow, MoltenCakeQtyNow, BananaCakeQtyNow, TiramisuCakeQtyNow, PancakeQtyNow, ApplePieQtyNow As Integer


    Public priceDesserts As Double
    Private Sub btnAddToCartSnacks_Click(sender As Object, e As EventArgs) Handles btnAddToCartSnacks.Click
        If chckCarrot.Checked = True Then
            CarrotCakeText = "Carrot Cake"

            CarrotCakeQtyNow = Val(txtCarrotQty.Text)
            CarrotCakePriceNow = 12 * CarrotCakeQtyNow

            CarrotCakeQty += Val(txtCarrotQty.Text)
            CarrotCakePrice = 12 * CarrotCakeQty

            lstMessage.Items.Add("Desserts Name: " & CarrotCakeText)
            lstMessage.Items.Add("Quantity: " & CarrotCakeQtyNow)
            lstMessage.Items.Add("Base Price: RM" & (CarrotCakePriceNow / CarrotCakeQtyNow).ToString("N2"))
            lstMessage.Items.Add("Total Carrot Cake: RM" & CarrotCakePriceNow.ToString("N2"))
            lstMessage.Items.Add("--------------------------------")
            lstMessage.Items.Add(vbNewLine)

            priceDesserts += CarrotCakePrice

        End If

        If chckMolten.Checked = True Then
            MoltenCakeText = "Molten Choco Cake"

            MoltenCakeQtyNow = Val(txtMoltenQty.Text)
            MoltenCakePriceNow = 13.5 * MoltenCakeQtyNow

            MoltenCakeQty += Val(txtMoltenQty.Text)
            MoltenCakePrice = 13.5 * MoltenCakeQty

            lstMessage.Items.Add("Desserts Name: " & MoltenCakeText)
            lstMessage.Items.Add("Quantity: " & MoltenCakeQtyNow)
            lstMessage.Items.Add("Base Price: RM" & (MoltenCakePriceNow / MoltenCakeQtyNow).ToString("N2"))
            lstMessage.Items.Add("Total Molten Cake: RM" & MoltenCakePriceNow.ToString("N2"))
            lstMessage.Items.Add("--------------------------------")
            lstMessage.Items.Add(vbNewLine)

            priceDesserts += MoltenCakePrice

        End If

        If chckBanana.Checked = True Then
            BananaCakeText = "Banana Cream Pie"

            BananaCakeQtyNow = Val(txtBananaQty.Text)
            BananaCakePriceNow = 8.9 * BananaCakeQtyNow

            BananaCakeQty += Val(txtBananaQty.Text)
            BananaCakePrice = 10.5 * BananaCakeQty

            lstMessage.Items.Add("Desserts Name: " & BananaCakeText)
            lstMessage.Items.Add("Quantity: " & BananaCakeQtyNow)
            lstMessage.Items.Add("Base Price: RM" & (BananaCakePriceNow / BananaCakeQtyNow).ToString("N2"))
            lstMessage.Items.Add("Total Banana Cake: RM" & BananaCakePriceNow.ToString("N2"))
            lstMessage.Items.Add("--------------------------------")
            lstMessage.Items.Add(vbNewLine)

            priceDesserts += BananaCakePrice

        End If

        If chckTiramisu.Checked = True Then
            TiramisuCakeText = "Tiramisu Cake"

            TiramisuCakeQtyNow = Val(txtTiramisuQty.Text)
            TiramisuCakePriceNow = 9 * TiramisuCakeQtyNow

            TiramisuCakeQty = Val(txtTiramisuQty.Text)
            TiramisuCakePrice = 9 * TiramisuCakeQty

            lstMessage.Items.Add("Desserts Name: " & TiramisuCakeText)
            lstMessage.Items.Add("Quantity: " & TiramisuCakeQtyNow)
            lstMessage.Items.Add("Base Price: RM" & (TiramisuCakePriceNow / TiramisuCakeQtyNow).ToString("N2"))
            lstMessage.Items.Add("Total Tiramisu Cake: RM" & TiramisuCakePriceNow.ToString("N2"))
            lstMessage.Items.Add("--------------------------------")
            lstMessage.Items.Add(vbNewLine)

            priceDesserts += TiramisuCakePrice

        End If

        If chckPancake.Checked = True Then
            PancakeText = "Pancake"

            PancakeQtyNow = Val(txtPancakeQty.Text)
            PancakePriceNow = 8.9 * PancakeQtyNow

            PancakeQty += Val(txtPancakeQty.Text)
            PancakePrice = 8.9 * PancakeQty

            lstMessage.Items.Add("Desserts Name: " & PancakeText)
            lstMessage.Items.Add("Quantity: " & PancakeQty)
            lstMessage.Items.Add("Base Price: RM" & (PancakePriceNow / PancakeQtyNow).ToString("N2"))
            lstMessage.Items.Add("Total Pancake: RM" & PancakePriceNow.ToString("N2"))
            lstMessage.Items.Add("--------------------------------")
            lstMessage.Items.Add(vbNewLine)

            priceDesserts += PancakePrice

        End If

        If chckApple.Checked = True Then
            ApplePieText = "Apple Pie"

            ApplePieQtyNow = Val(txtAppleQty.Text)
            ApplePiePriceNow = 7.9 * ApplePieQtyNow

            ApplePieQty += Val(txtAppleQty.Text)
            ApplePiePrice = 7.9 * ApplePieQty

            lstMessage.Items.Add("Desserts Name: " & ApplePieText)
            lstMessage.Items.Add("Quantity: " & ApplePieQtyNow)
            lstMessage.Items.Add("Base Price: RM" & (ApplePiePriceNow / ApplePieQtyNow).ToString("N2"))
            lstMessage.Items.Add("Total Apple Pie: RM" & ApplePiePriceNow.ToString("N2"))
            lstMessage.Items.Add("--------------------------------")
            lstMessage.Items.Add(vbNewLine)

            priceDesserts += ApplePiePrice

        End If

    End Sub
    Private Sub btnSnacks_Click(sender As Object, e As EventArgs) Handles btnSnacks.Click
        Me.Hide()
        Snacks.Show()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Me.Hide()
        Checkout.Show()
    End Sub

    Private Sub btnCarrotAbout_Click(sender As Object, e As EventArgs) Handles btnCarrotAbout.Click
        lblAboutDesserts.Text = "Moist, spiced cakes layered with creamy frosting, embodying a harmonious blend of carrots, cinnamon, and nuts for a delightful balance of sweetness and warmth in every bite."

        picApplePie.Visible = False
        picBanana.Visible = False
        picCarrot.Visible = True
        picMolten.Visible = False
        picPancake.Visible = False
        picTiramisu.Visible = False
    End Sub

    Private Sub btnMoltenAbout_Click(sender As Object, e As EventArgs) Handles btnMoltenAbout.Click
        lblAboutDesserts.Text = "Decadent molten chocolate cakes, oozing with rich, warm chocolate from their center, offering a heavenly indulgence for any chocolate lover seeking a sumptuous, melt-in-your-mouth dessert experience."

        picApplePie.Visible = False
        picBanana.Visible = False
        picCarrot.Visible = False
        picMolten.Visible = True
        picPancake.Visible = False
        picTiramisu.Visible = False

    End Sub
    Private Sub btnBananaAbout_Click(sender As Object, e As EventArgs) Handles btnBananaAbout.Click
        lblAboutDesserts.Text = "A symphony of flavors harmonizing in a dessert masterpiece. Enter the world of banana cream pie—a celestial blend of velvety custard, ripe bananas, and a delicate crust, promising a delightful adventure for your taste buds. This classic indulgence is a testament to comfort and nostalgia, inviting you to savor every creamy, dreamy bite."

        picApplePie.Visible = False
        picBanana.Visible = True
        picCarrot.Visible = False
        picMolten.Visible = False
        picPancake.Visible = False
        picTiramisu.Visible = False

    End Sub

    Private Sub btnTiramisuAbout_Click(sender As Object, e As EventArgs) Handles btnTiramisuAbout.Click
        lblAboutDesserts.Text = "Tiramisu, an elegant Italian dessert, layers delicate ladyfinger biscuits soaked in coffee and layered with a rich mascarpone cheese mixture, dusted with cocoa powder—a harmonious blend of coffee, creaminess, and subtle sweetness in each decadent bite."

        picApplePie.Visible = False
        picBanana.Visible = False
        picCarrot.Visible = False
        picMolten.Visible = False
        picPancake.Visible = False
        picTiramisu.Visible = True

    End Sub

    Private Sub btnPancakeAbout_Click(sender As Object, e As EventArgs) Handles btnPancakeAbout.Click
        lblAboutDesserts.Text = "Fluffy, golden pancakes, cooked to perfection and served with a drizzle of maple syrup, embodying a comforting warmth and lightness that makes every morning a delightful start."

        picApplePie.Visible = False
        picBanana.Visible = False
        picCarrot.Visible = False
        picMolten.Visible = False
        picPancake.Visible = True
        picTiramisu.Visible = False

    End Sub

    Private Sub btnAppleAbout_Click(sender As Object, e As EventArgs) Handles btnAppleAbout.Click
        lblAboutDesserts.Text = "Classic apple pie, a timeless treat with a flaky crust embracing tender, cinnamon-kissed apple slices, baked to golden perfection—a nostalgic taste of home in every slice."

        picApplePie.Visible = True
        picBanana.Visible = False
        picCarrot.Visible = False
        picMolten.Visible = False
        picPancake.Visible = False
        picTiramisu.Visible = False

    End Sub

    Private Sub chckCarrot_CheckedChanged(sender As Object, e As EventArgs) Handles chckCarrot.CheckedChanged
        If chckCarrot.Checked = True Then
            txtCarrotQty.ReadOnly = False
        Else
            txtCarrotQty.ReadOnly = True
            txtCarrotQty.Clear()
        End If
    End Sub

    Private Sub chckMolten_CheckedChanged(sender As Object, e As EventArgs) Handles chckMolten.CheckedChanged
        If chckMolten.Checked = True Then
            txtMoltenQty.ReadOnly = False
        Else
            txtMoltenQty.ReadOnly = True
            txtMoltenQty.Clear()
        End If
    End Sub

    Private Sub chckBanana_CheckedChanged(sender As Object, e As EventArgs) Handles chckBanana.CheckedChanged
        If chckBanana.Checked = True Then
            txtBananaQty.ReadOnly = False
        Else
            txtBananaQty.ReadOnly = True
            txtBananaQty.Clear()
        End If
    End Sub

    Private Sub chckTiramisu_CheckedChanged(sender As Object, e As EventArgs) Handles chckTiramisu.CheckedChanged
        If chckTiramisu.Checked = True Then
            txtTiramisuQty.ReadOnly = False
        Else
            txtTiramisuQty.ReadOnly = True
            txtTiramisuQty.Clear()
        End If
    End Sub

    Private Sub chckPancake_CheckedChanged(sender As Object, e As EventArgs) Handles chckPancake.CheckedChanged
        If chckPancake.Checked = True Then
            txtPancakeQty.ReadOnly = False
        Else
            txtPancakeQty.ReadOnly = True
            txtPancakeQty.Clear()
        End If
    End Sub

    Private Sub chckApple_CheckedChanged(sender As Object, e As EventArgs) Handles chckApple.CheckedChanged
        If chckApple.Checked = True Then
            txtAppleQty.ReadOnly = False
        Else
            txtAppleQty.ReadOnly = True
            txtAppleQty.Clear()
        End If
    End Sub
    Private Sub Desserts_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class

