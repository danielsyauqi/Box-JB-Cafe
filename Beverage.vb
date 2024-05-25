Public Class Beverage
    Public TypeBeverage As String

    'Price Total by Beverages Product
    Public HoneyTeaPrice, GreenTeaPrice, MilkTeaPrice, JasmineTeaPrice As Double
    Public CaramelMacchiatoPrice, EspressoPrice, MochaPrice, AmericanoPrice As Double
    Public JavaChipPrice, CaramelFrappPrice, CaffeVanillaPrice, MochaCookiePrice As Double
    'String Text for Beverages Name
    Public HoneyTeaText, GreenTeaText, MilkTeaText, JasmineTeaText As String
    Public CaramelMacchiatoText, EspressoText, MochaText, AmericanoText As String
    Public JavaChipText, CaramelFrappText, CaffeVanillaText, MochaCookieText As String
    'Quantity Total by Beverages Product
    Public HoneyTeaQty, GreenTeaQty, MilkTeaQty, JasmineTeaQty As Integer
    Public CaramelMacchiatoQty, EspressoQty, MochaQty, AmericanoQty As Integer
    Public JavaChipQty, CaramelFrappQty, CaffeVanillaQty, MochaCookieQty As Integer

    'Quantity Added Value
    Public HoneyTeaQtyNow, GreenTeaQtyNow, MilkTeaQtyNow, JasmineTeaQtyNow As Integer
    Public CaramelMacchiatoQtyNow, EspressoQtyNow, MochaQtyNow, AmericanoQtyNow As Integer
    Public JavaChipQtyNow, CaramelFrappQtyNow, CaffeVanillaQtyNow, MochaCookieQtyNow As Integer


    'Price Added Value
    Public HoneyTeaPriceNow, GreenTeaPriceNow, MilkTeaPriceNow, JasmineTeaPriceNow As Double
    Public CaramelMacchiatoPriceNow, EspressoPriceNow, MochaPriceNow, AmericanoPriceNow As Double
    Public JavaChipPriceNow, CaramelFrappPriceNow, CaffeVanillaPriceNow, MochaCookiePriceNow As Double
    'Price Total by Beverages Tyoe
    Public priceTea, priceCoffee, priceFrapp, priceBeverage As Double
    Public quantity As Integer



    Private Sub btnAddToCartBeverage_Click(sender As Object, e As EventArgs) Handles btnAddToCartBeverage.Click
        lstMessage.Items.Add("You have add to cart these items!")
        lstMessage.Items.Add("===============================================")

        'If Tea section checked
        If radTea.Checked = True Then

            'If Honey Tea checked
            If chckHoneyTea.Checked = True Then
                HoneyTeaText = "Honey Tea"

                'Honey Tea Quantity & Price (Added Value)
                HoneyTeaQtyNow = Val(txtHoneyQty.Text)
                HoneyTeaPriceNow = 6.9 * HoneyTeaQtyNow

                'Honey Tea Quantity & Price (Added Value)
                HoneyTeaQty += Val(txtHoneyQty.Text)
                HoneyTeaPrice = 6.9 * HoneyTeaQty

                'Print
                lstMessage.Items.Add("Beverage Name: " & HoneyTeaText)
                lstMessage.Items.Add("Quantity: " & HoneyTeaQtyNow)
                lstMessage.Items.Add("Base Price: RM" & (HoneyTeaPriceNow / HoneyTeaQtyNow).ToString("N2"))
                lstMessage.Items.Add("Total Honey Tea: RM" & HoneyTeaPriceNow.ToString("N2"))
                lstMessage.Items.Add("--------------------------------")
                lstMessage.Items.Add(vbNewLine)

                'Total operation
                priceTea += HoneyTeaPrice

            End If


            If chckGreenTea.Checked = True Then
                GreenTeaText = "Green Tea"

                'Green Tea Quantity & Price (Added Value)
                GreenTeaQtyNow = Val(txtGreenQty.Text)
                GreenTeaPriceNow = 7.9 * GreenTeaQtyNow

                'Green Tea Quantity & Price (Total)
                GreenTeaQty += Val(txtGreenQty.Text)
                GreenTeaPrice = 7.9 * GreenTeaQty

                lstMessage.Items.Add("Beverage Name: " & GreenTeaText)
                lstMessage.Items.Add("Quantity: " & GreenTeaQtyNow)
                lstMessage.Items.Add("Base Price: RM" & (GreenTeaPriceNow / GreenTeaQtyNow).ToString("N2"))
                lstMessage.Items.Add("Total Green Tea: RM" & GreenTeaPriceNow.ToString("N2"))
                lstMessage.Items.Add("--------------------------------")
                lstMessage.Items.Add(vbNewLine)

                priceTea += AmericanoPrice
            End If
            If chckMilkTea.Checked = True Then
                MilkTeaText = "Milk Tea"

                MilkTeaQtyNow = Val(txtMilkQty.Text)
                MilkTeaPriceNow = 10.9 * MilkTeaQtyNow

                MilkTeaQty += Val(txtMilkQty.Text)
                MilkTeaPrice = 10.9 * MilkTeaQty

                lstMessage.Items.Add("Beverage Name: " & MilkTeaText)
                lstMessage.Items.Add("Quantity: " & MilkTeaQtyNow)
                lstMessage.Items.Add("Base Price: RM" & (MilkTeaPriceNow / MilkTeaQtyNow).ToString("N2"))
                lstMessage.Items.Add("Total Milk Tea: RM" & MilkTeaPriceNow.ToString("N2"))
                lstMessage.Items.Add("--------------------------------")
                lstMessage.Items.Add(vbNewLine)

                priceTea += MilkTeaPrice
            End If
            If chckJasmineTea.Checked = True Then
                JasmineTeaText = "Jasmine Tea"

                JasmineTeaQtyNow = Val(txtJasmineQty.Text)
                JasmineTeaPriceNow = 8.9 * JasmineTeaQtyNow

                JasmineTeaQty += Val(txtJasmineQty.Text)
                JasmineTeaPrice = 8.9 * JasmineTeaQty

                lstMessage.Items.Add("Beverage Name: " & JasmineTeaText)
                lstMessage.Items.Add("Quantity: " & JasmineTeaQtyNow)
                lstMessage.Items.Add("Base Price: RM" & (JasmineTeaPriceNow / JasmineTeaQtyNow).ToString("N2"))
                lstMessage.Items.Add("Total Jasmine Tea: RM" & JasmineTeaPriceNow.ToString("N2"))
                lstMessage.Items.Add("--------------------------------")
                lstMessage.Items.Add(vbNewLine)

                priceTea += JasmineTeaPrice

            End If
        End If

        If radCoffee.Checked = True Then

            If chckCaramel.Checked = True Then
                CaramelMacchiatoText = "Caramel Macchiato"

                CaramelMacchiatoQtyNow = Val(txtCaramelQty.Text)
                CaramelMacchiatoPriceNow = 12.9 * HoneyTeaQtyNow

                CaramelMacchiatoQty += Val(txtCaramelQty.Text)
                CaramelMacchiatoPrice = 12.9 * CaramelMacchiatoQty

                lstMessage.Items.Add("Beverage Name: " & CaramelMacchiatoText)
                lstMessage.Items.Add("Quantity: " & CaramelMacchiatoQtyNow)
                lstMessage.Items.Add("Base Price: RM" & (CaramelMacchiatoPriceNow / CaramelMacchiatoQtyNow).ToString("N2"))
                lstMessage.Items.Add("Total Caramel Macchiato: RM" & CaramelMacchiatoPriceNow.ToString("N2"))
                lstMessage.Items.Add("--------------------------------")
                lstMessage.Items.Add(vbNewLine)

                priceCoffee += CaramelMacchiatoPrice
            End If
            If chckEspresso.Checked = True Then
                EspressoText = "Espresso"

                EspressoQtyNow = Val(txtEspressoQty.Text)
                EspressoPriceNow = 10.9 * EspressoQtyNow

                EspressoQty += Val(txtEspressoQty.Text)
                EspressoPrice = 10.9 * EspressoQty

                lstMessage.Items.Add("Beverage Name: " & EspressoText)
                lstMessage.Items.Add("Quantity: " & EspressoQtyNow)
                lstMessage.Items.Add("Base Price: RM" & (EspressoPriceNow / EspressoQtyNow).ToString("N2"))
                lstMessage.Items.Add("Total Espresso: RM" & EspressoPriceNow.ToString("N2"))
                lstMessage.Items.Add("--------------------------------")

                lstMessage.Items.Add(vbNewLine)
                priceCoffee += EspressoPrice
            End If
            If chckMocha.Checked = True Then
                MochaText = "Mocha"

                MochaQtyNow = Val(txtMochaQty.Text)
                MochaPriceNow = 11.9 * MochaQtyNow

                MochaQty += Val(txtMochaQty.Text)
                MochaPrice = 11.9 * MochaQty

                lstMessage.Items.Add("Beverage Name: " & MochaText)
                lstMessage.Items.Add("Quantity: " & MochaQtyNow)
                lstMessage.Items.Add("Base Price: RM" & (MochaPriceNow / MochaQtyNow).ToString("N2"))
                lstMessage.Items.Add("Total Mocha: RM" & MochaPriceNow.ToString("N2"))
                lstMessage.Items.Add("--------------------------------")
                lstMessage.Items.Add(vbNewLine)

                priceCoffee += MochaPrice
            End If
            If chckAmericano.Checked = True Then
                AmericanoText = "Americano"

                AmericanoQtyNow = Val(txtAmericanoQty.Text)
                AmericanoPriceNow = 6.9 * AmericanoQtyNow

                AmericanoQty += Val(txtAmericanoQty.Text)
                AmericanoPrice = 6.9 * AmericanoQty

                lstMessage.Items.Add("Beverage Name: " & AmericanoText)
                lstMessage.Items.Add("Quantity: " & AmericanoQtyNow)
                lstMessage.Items.Add("Base Price: RM" & (AmericanoPriceNow / AmericanoQtyNow).ToString("N2"))
                lstMessage.Items.Add("Total Americano: RM" & AmericanoPriceNow.ToString("N2"))
                lstMessage.Items.Add("--------------------------------")
                lstMessage.Items.Add(vbNewLine)

                priceCoffee += AmericanoPrice

            End If
        End If

        If radFrappe.Checked Then

            If chckJavachip.Checked Then

                JavaChipText = "Java Chip Frappucino"

                JavaChipQtyNow = Val(txtJavachipQty.Text)
                JavaChipPriceNow = 16.9 * JavaChipQtyNow

                JavaChipQty += Val(txtJavachipQty.Text)
                JavaChipPrice = 16.9 * JavaChipQty

                lstMessage.Items.Add("Beverage Name: " & JavaChipText)
                lstMessage.Items.Add("Quantity: " & JavaChipQtyNow)
                lstMessage.Items.Add("Base Price: RM" & (JavaChipPriceNow / JavaChipQtyNow).ToString("N2"))
                lstMessage.Items.Add("Total Java Chip Frappucino: RM" & JavaChipPriceNow.ToString("N2"))
                lstMessage.Items.Add("--------------------------------")
                lstMessage.Items.Add(vbNewLine)

                priceFrapp += JavaChipPrice
            End If
            If chckCaramelFrapp.Checked Then
                CaramelFrappText = "Caramel Frappucino"

                CaramelFrappQtyNow = Val(txtCaramelFrappQty.Text)
                CaramelFrappPriceNow = 14.9 * CaramelFrappQtyNow

                CaramelFrappQty += Val(txtCaramelFrappQty.Text)
                CaramelFrappPrice = 14.9 * CaramelFrappQty

                lstMessage.Items.Add("Beverage Name: " & CaramelFrappText)
                lstMessage.Items.Add("Quantity: " & CaramelFrappQtyNow)
                lstMessage.Items.Add("Base Price: RM" & (CaramelFrappPriceNow / CaramelFrappQtyNow).ToString("N2"))
                lstMessage.Items.Add("Total Caramel Frappucino: RM" & CaramelFrappPriceNow.ToString("N2"))
                lstMessage.Items.Add("--------------------------------")
                lstMessage.Items.Add(vbNewLine)

                priceFrapp += CaramelFrappPrice
            End If
            If chckVanilla.Checked Then
                CaffeVanillaText = "Caffe Vanilla Frappucino"

                CaffeVanillaQtyNow = Val(txtVanillaQty.Text)
                CaffeVanillaPriceNow = 14.9 * CaffeVanillaQtyNow

                CaffeVanillaQty += Val(txtVanillaQty.Text)
                CaffeVanillaPrice = 14.9 * CaffeVanillaQty

                lstMessage.Items.Add("Beverage Name: " & CaffeVanillaText)
                lstMessage.Items.Add("Quantity: " & CaffeVanillaQtyNow)
                lstMessage.Items.Add("Base Price: RM" & (CaffeVanillaPriceNow / CaffeVanillaQtyNow).ToString("N2"))
                lstMessage.Items.Add("Total Caffe Vanilla Frappucino: RM" & CaffeVanillaPriceNow.ToString("N2"))
                lstMessage.Items.Add("--------------------------------")
                lstMessage.Items.Add(vbNewLine)

                priceFrapp += CaffeVanillaPrice
            End If
            If chckCookie.Checked Then
                MochaCookieText = "Mocha Cookie Frappucino"

                MochaCookieQtyNow = Val(txtCookieQty.Text)
                MochaCookiePriceNow = 15.9 * MochaCookieQtyNow

                MochaCookieQty += Val(txtCookieQty.Text)
                MochaCookiePrice = 15.9 * MochaCookieQty

                lstMessage.Items.Add("Beverage Name: " & MochaCookieText)
                lstMessage.Items.Add("Quantity: " & MochaCookieQtyNow)
                lstMessage.Items.Add("Base Price: RM" & (MochaCookiePriceNow / MochaCookieQtyNow).ToString("N2"))
                lstMessage.Items.Add("Total Mocha Cookie Frappucino: RM" & MochaCookiePriceNow.ToString("N2"))
                lstMessage.Items.Add("--------------------------------")

                lstMessage.Items.Add(vbNewLine)

            End If
        End If

        priceBeverage = priceCoffee + priceFrapp + priceTea
    End Sub
    Private Sub radFrappe_CheckedChanged(sender As Object, e As EventArgs) Handles radFrappe.CheckedChanged
        gpFrappe.Visible = True
        gpFrappe.BringToFront()
        gpCoffee.Visible = True
        groupTea.Visible = True

        If radFrappe.Checked = False Then
            txtCaramelFrappQty.ReadOnly = True
            txtJavachipQty.ReadOnly = True
            txtVanillaQty.ReadOnly = True
            txtCookieQty.ReadOnly = True

            chckCaramelFrapp.Checked = False
            chckJavachip.Checked = False
            chckVanilla.Checked = False
            chckCookie.Checked = False

            txtCaramelFrappQty.Clear()
            txtJavachipQty.Clear()
            txtVanillaQty.Clear()
            txtCookieQty.Clear()
        End If
    End Sub

    Private Sub radCoffee_CheckedChanged(sender As Object, e As EventArgs) Handles radCoffee.CheckedChanged
        gpCoffee.Visible = True
        gpFrappe.SendToBack()
        gpFrappe.Visible = True
        groupTea.Visible = True

        If radCoffee.Checked = False Then
            txtCaramelQty.ReadOnly = True
            txtEspressoQty.ReadOnly = True
            txtMochaQty.ReadOnly = True
            txtAmericanoQty.ReadOnly = True

            chckCaramel.Checked = False
            chckEspresso.Checked = False
            chckMocha.Checked = False
            chckAmericano.Checked = False

            txtCaramelQty.Clear()
            txtEspressoQty.Clear()
            txtMochaQty.Clear()
            txtAmericanoQty.Clear()
        End If
    End Sub
    Private Sub radTea_CheckedChanged(sender As Object, e As EventArgs) Handles radTea.CheckedChanged
        gpCoffee.Visible = False
        gpFrappe.Visible = False
        groupTea.Visible = True

        If radTea.Checked = False Then
            chckHoneyTea.Checked = False
            chckGreenTea.Checked = False
            chckMilkTea.Checked = False
            chckJasmineTea.Checked = False

            txtHoneyQty.ReadOnly = True
            txtGreenQty.ReadOnly = True
            txtMilkQty.ReadOnly = True
            txtJasmineQty.ReadOnly = True

            txtHoneyQty.Clear()
            txtGreenQty.Clear()
            txtMilkQty.Clear()
            txtJasmineQty.Clear()
        End If
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Me.Hide()
        Checkout.Show()
    End Sub

    Private Sub btnSnacks_Click(sender As Object, e As EventArgs) Handles btnSnacks.Click
        Me.Hide()
        Snacks.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        MenuForm.Show()
    End Sub

    Private Sub btnMilkAbout_Click(sender As Object, e As EventArgs) Handles btnMilkAbout.Click
        lblAboutBeverages.Text = "Dive into the nostalgia of our Classic Milk Tea, an exquisite blend that seamlessly weaves together the bold essence of premium black tea leaves and the velvety richness of fresh milk. Crafted with care, this beverage is a celebration of comforting flavors that dance on your palate, offering a gratifying experience with every delightful sip."
        picMilkTea.Visible = True
        picGreenTea.Visible = False
        picHoneyTea.Visible = False
        picJasmineTea.Visible = False
        picCaramelMac.Visible = False
        picEspresso.Visible = False
        picMocha.Visible = False
        picAmericano.Visible = False
        picCaramelFrapp.Visible = False
        picJavachip.Visible = False
        picVanilla.Visible = False
        picCookies.Visible = False

    End Sub

    Private Sub btnJasmineAbout_Click(sender As Object, e As EventArgs) Handles btnJasmineAbout.Click
        lblAboutBeverages.Text = "Embark on a fragrant journey with our Jasmine Bliss Tea, a delicate fusion of premium green tea leaves adorned with the enchanting essence of jasmine blossoms. This aromatic creation is a tribute to tranquility, offering a floral symphony that captivates the senses and transports you to a realm of pure serenity with each gentle sip."
        picMilkTea.Visible = False
        picGreenTea.Visible = False
        picHoneyTea.Visible = False
        picJasmineTea.Visible = True
        picCaramelMac.Visible = False
        picEspresso.Visible = False
        picMocha.Visible = False
        picAmericano.Visible = False
        picCaramelFrapp.Visible = False
        picJavachip.Visible = False
        picVanilla.Visible = False
        picCookies.Visible = False

    End Sub

    Private Sub btnCaramelAbout_Click(sender As Object, e As EventArgs) Handles btnCaramelAbout.Click
        lblAboutBeverages.Text = "Indulge in the luxurious fusion of espresso and velvety steamed milk, crowned with a drizzle of decadent caramel in our Caramel Macchiato. A symphony of contrasting flavors and textures, this artisanal creation is a true celebration for your senses, promising a harmonious balance of bold espresso and luscious sweetness in every sip."
        picMilkTea.Visible = False
        picGreenTea.Visible = False
        picHoneyTea.Visible = False
        picJasmineTea.Visible = False
        picCaramelMac.Visible = True
        picEspresso.Visible = False
        picMocha.Visible = False
        picAmericano.Visible = False
        picCaramelFrapp.Visible = False
        picJavachip.Visible = False
        picVanilla.Visible = False
        picCookies.Visible = False
    End Sub
    Private Sub btnEspressoAbout_Click(sender As Object, e As EventArgs) Handles btnEspressoAbout.Click
        lblAboutBeverages.Text = "Experience the essence Of bold simplicity With our Pure Espresso Elegance. Immerse yourself In the rich, concentrated flavor Of finely crafted espresso beans, delivering a robust And invigorating caffeine kick. This unadulterated coffee experience Is a testament To the pure And intense pleasure found In every small but mighty sip."
        picMilkTea.Visible = False
        picGreenTea.Visible = False
        picHoneyTea.Visible = False
        picJasmineTea.Visible = False
        picCaramelMac.Visible = False
        picEspresso.Visible = True
        picMocha.Visible = False
        picAmericano.Visible = False
        picCaramelFrapp.Visible = False
        picJavachip.Visible = False
        picVanilla.Visible = False
        picCookies.Visible = False
    End Sub

    Private Sub btnAmericanoAbout_Click(sender As Object, e As EventArgs) Handles btnAmericanoAbout.Click
        lblAboutBeverages.Text = "Awaken your senses with our Classic Americano, a timeless creation that celebrates the purity of espresso. This straightforward yet invigorating beverage is crafted by diluting a rich shot of espresso with hot water, offering a clean and robust coffee experience that allows the bold flavors to shine through, sip after satisfying sip."
        picMilkTea.Visible = False
        picGreenTea.Visible = False
        picHoneyTea.Visible = False
        picJasmineTea.Visible = False
        picCaramelMac.Visible = False
        picEspresso.Visible = False
        picMocha.Visible = False
        picAmericano.Visible = True
        picCaramelFrapp.Visible = False
        picJavachip.Visible = False
        picVanilla.Visible = False
        picCookies.Visible = False
    End Sub

    Private Sub btnMochaAbout_Click(sender As Object, e As EventArgs) Handles btnMochaAbout.Click
        lblAboutBeverages.Text = "Satisfy your cravings with our Decadent Mocha Bliss, a luscious fusion of rich espresso, velvety steamed milk, and a generous dollop of indulgent chocolate. This irresistible concoction marries the boldness of coffee with the smooth sweetness of cocoa, creating a harmonious blend that delights the palate and elevates your coffee experience to new heights."
        picMilkTea.Visible = False
        picGreenTea.Visible = False
        picHoneyTea.Visible = False
        picJasmineTea.Visible = False
        picCaramelMac.Visible = False
        picEspresso.Visible = False
        picMocha.Visible = True
        picAmericano.Visible = False
        picCaramelFrapp.Visible = False
        picJavachip.Visible = False
        picVanilla.Visible = False
        picCookies.Visible = False
    End Sub

    Private Sub btnJavachipAbout_Click(sender As Object, e As EventArgs) Handles btnJavachipAbout.Click
        lblAboutBeverages.Text = "Escape into indulgence with our Java Chip Frappuccino, a delightful blend of bold coffee, velvety milk, ice, and decadent chocolate chips. This icy concoction takes the classic frappé to new heights, offering a refreshing and satisfying experience that seamlessly combines the invigorating kick of coffee with the irresistible allure of rich chocolate."
        picMilkTea.Visible = False
        picGreenTea.Visible = False
        picHoneyTea.Visible = False
        picJasmineTea.Visible = False
        picCaramelMac.Visible = False
        picEspresso.Visible = False
        picMocha.Visible = False
        picAmericano.Visible = False
        picCaramelFrapp.Visible = False
        picJavachip.Visible = True
        picVanilla.Visible = False
        picCookies.Visible = False
    End Sub

    Private Sub btnCaramelFrappAbout_Click(sender As Object, e As EventArgs) Handles btnCaramelFrappAbout.Click
        lblAboutBeverages.Text = "Immerse yourself in the pure indulgence of our Caramel Frappé, a velvety blend of freshly brewed coffee, ice, and the sweet allure of caramel. This icy sensation is a symphony of cool refreshment and decadent sweetness, perfect for those seeking a delightful escape into a world of creamy bliss."
        picMilkTea.Visible = False
        picGreenTea.Visible = False
        picHoneyTea.Visible = False
        picJasmineTea.Visible = False
        picCaramelMac.Visible = False
        picEspresso.Visible = False
        picMocha.Visible = False
        picAmericano.Visible = False
        picCaramelFrapp.Visible = True
        picJavachip.Visible = False
        picVanilla.Visible = False
        picCookies.Visible = False
    End Sub

    Private Sub btnVanillaAbout_Click(sender As Object, e As EventArgs) Handles btnVanillaAbout.Click
        lblAboutBeverages.Text = "Experience pure sophistication with our Vanilla Frappé, a luxurious fusion of premium coffee, ice, and the timeless allure of vanilla. This velvety creation is a symphony of cool refreshment and sweet indulgence, offering a delightful escape into a world of smooth, creamy elegance."
        picMilkTea.Visible = False
        picGreenTea.Visible = False
        picHoneyTea.Visible = False
        picJasmineTea.Visible = False
        picCaramelMac.Visible = False
        picEspresso.Visible = False
        picMocha.Visible = False
        picAmericano.Visible = False
        picCaramelFrapp.Visible = False
        picJavachip.Visible = False
        picVanilla.Visible = True
        picCookies.Visible = False
    End Sub

    Private Sub btnCookieAbout_Click(sender As Object, e As EventArgs) Handles btnCookieAbout.Click
        lblAboutBeverages.Text = "Embark on a journey of decadence with our Mocha Cookie Frappé, a luxurious blend of rich espresso, ice, creamy milk, and the irresistible allure of chocolate cookies. This indulgent creation is a symphony of cool refreshment and sweet nostalgia, offering a delightful escape into a world where the boldness of coffee meets the delightful crunch of chocolate cookies."
        picMilkTea.Visible = False
        picGreenTea.Visible = False
        picHoneyTea.Visible = False
        picJasmineTea.Visible = False
        picCaramelMac.Visible = False
        picEspresso.Visible = False
        picMocha.Visible = False
        picAmericano.Visible = False
        picCaramelFrapp.Visible = False
        picJavachip.Visible = False
        picVanilla.Visible = False
        picCookies.Visible = True
    End Sub

    Private Sub btnGreenAbout_Click(sender As Object, e As EventArgs) Handles btnGreenAbout.Click
        lblAboutBeverages.Text = "Immerse yourself in the pure essence of our Green Tea, a classic blend showcasing the delicate flavors of premium green tea leaves. Sourced for their freshness and vibrancy, this beverage offers a serene and authentic tea experience.About Green"
        picMilkTea.Visible = False
        picGreenTea.Visible = True
        picHoneyTea.Visible = False
        picJasmineTea.Visible = False
        picCaramelMac.Visible = False
        picEspresso.Visible = False
        picMocha.Visible = False
        picAmericano.Visible = False
        picCaramelFrapp.Visible = False
        picJavachip.Visible = False
        picVanilla.Visible = False
        picCookies.Visible = False
    End Sub

    Private Sub btnHoneyAbout_Click(sender As Object, e As EventArgs) Handles btnHoneyAbout.Click
        lblAboutBeverages.Text = "Indulge in our soothing Honey Tea, a harmonious blend of premium tea leaves and the natural sweetness of pure honey. Carefully brewed to perfection, this delightful beverage offers a comforting experience with every sip."
        picMilkTea.Visible = False
        picGreenTea.Visible = False
        picHoneyTea.Visible = True
        picJasmineTea.Visible = False
        picCaramelMac.Visible = False
        picEspresso.Visible = False
        picMocha.Visible = False
        picAmericano.Visible = False
        picCaramelFrapp.Visible = False
        picJavachip.Visible = False
        picVanilla.Visible = False
        picCookies.Visible = False
    End Sub

    Private Sub chckHoneyTea_CheckedChanged(sender As Object, e As EventArgs) Handles chckHoneyTea.CheckedChanged
        If chckHoneyTea.Checked = True Then
            txtHoneyQty.ReadOnly = False
        Else
            txtHoneyQty.ReadOnly = True
            txtHoneyQty.Clear()
        End If
    End Sub

    Private Sub chckGreenTea_CheckedChanged(sender As Object, e As EventArgs) Handles chckGreenTea.CheckedChanged
        If chckGreenTea.Checked = True Then
            txtGreenQty.ReadOnly = False
        Else
            txtGreenQty.ReadOnly = True
            txtGreenQty.Clear()
        End If
    End Sub

    Private Sub chckMilkTea_CheckedChanged(sender As Object, e As EventArgs) Handles chckMilkTea.CheckedChanged
        If chckMilkTea.Checked = True Then
            txtMilkQty.ReadOnly = False
        Else
            txtMilkQty.ReadOnly = True
            txtMilkQty.Clear()
        End If
    End Sub


    Private Sub chckJasmineTea_CheckedChanged(sender As Object, e As EventArgs) Handles chckJasmineTea.CheckedChanged
        If chckJasmineTea.Checked = True Then
            txtJasmineQty.ReadOnly = False
        Else
            txtJasmineQty.ReadOnly = True
            txtJasmineQty.Clear()
        End If
    End Sub

    Private Sub chckCaramel_CheckedChanged(sender As Object, e As EventArgs) Handles chckCaramel.CheckedChanged
        If chckCaramel.Checked = True Then
            txtCaramelQty.ReadOnly = False
        Else
            txtCaramelQty.ReadOnly = True
            txtCaramelQty.Clear()
        End If
    End Sub

    Private Sub chckEspresso_CheckedChanged(sender As Object, e As EventArgs) Handles chckEspresso.CheckedChanged
        If chckEspresso.Checked = True Then
            txtEspressoQty.ReadOnly = False
        Else
            txtEspressoQty.ReadOnly = True
            txtEspressoQty.Clear()
        End If
    End Sub

    Private Sub chckMocha_CheckedChanged(sender As Object, e As EventArgs) Handles chckMocha.CheckedChanged
        If chckMocha.Checked = True Then
            txtMochaQty.ReadOnly = False
        Else
            txtMochaQty.ReadOnly = True
            txtMochaQty.Clear()
        End If
    End Sub

    Private Sub chckAmericano_CheckedChanged(sender As Object, e As EventArgs) Handles chckAmericano.CheckedChanged
        If chckAmericano.Checked = True Then
            txtAmericanoQty.ReadOnly = False
        Else
            txtAmericanoQty.ReadOnly = True
            txtAmericanoQty.Clear()
        End If
    End Sub

    Private Sub chckJavachip_CheckedChanged(sender As Object, e As EventArgs) Handles chckJavachip.CheckedChanged
        If chckJavachip.Checked = True Then
            txtJavachipQty.ReadOnly = False
        Else
            txtJavachipQty.ReadOnly = True
            txtJavachipQty.Clear()
        End If
    End Sub

    Private Sub chckCaramelFrapp_CheckedChanged(sender As Object, e As EventArgs) Handles chckCaramelFrapp.CheckedChanged
        If chckCaramelFrapp.Checked = True Then
            txtCaramelFrappQty.ReadOnly = False
        Else
            txtCaramelFrappQty.ReadOnly = True
            txtCaramelFrappQty.Clear()
        End If
    End Sub

    Private Sub chckVanilla_CheckedChanged(sender As Object, e As EventArgs) Handles chckVanilla.CheckedChanged
        If chckVanilla.Checked = True Then
            txtVanillaQty.ReadOnly = False
        Else
            txtVanillaQty.ReadOnly = True
            txtVanillaQty.Clear()
        End If
    End Sub

    Private Sub chckCookie_CheckedChanged(sender As Object, e As EventArgs) Handles chckCookie.CheckedChanged
        If chckCookie.Checked = True Then
            txtCookieQty.ReadOnly = False
        Else
            txtCookieQty.ReadOnly = True
        End If
    End Sub

    Private Sub Beverage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class