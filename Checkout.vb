Imports System.Drawing.Printing
Imports System.IO

Public Class Checkout

    Private Sub btnDisplayOrder_Click(sender As Object, e As EventArgs) Handles btnDisplayOrder.Click
        lstDisplayOrder.Items.Add("============================================================================")
        lstDisplayOrder.Items.Add(vbTab & vbTab & "FINAL RECEIPT")
        lstDisplayOrder.Items.Add("============================================================================")
        lstDisplayOrder.Items.Add("Customer Name: " & MenuForm.CustName)
        lstDisplayOrder.Items.Add("Table Number: " & MenuForm.TableNum)
        lstDisplayOrder.Items.Add("----------------------------------------------------------------------------")
        lstDisplayOrder.Items.Add(vbTab & vbTab & "MENU ORDER ")
        lstDisplayOrder.Items.Add("----------------------------------------------------------------------------")
        'Tea Section
        If Beverage.HoneyTeaQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Beverage.HoneyTeaText & " X" & Beverage.HoneyTeaQty)
        End If
        If Beverage.GreenTeaQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Beverage.GreenTeaText & " X" & Beverage.GreenTeaQty)
        End If
        If Beverage.MilkTeaQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Beverage.MilkTeaText & " X" & Beverage.MilkTeaQty)
        End If
        If Beverage.JasmineTeaQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Beverage.JasmineTeaText & " X" & Beverage.JasmineTeaQty)
        End If

        'Coffee Section
        If Beverage.CaramelMacchiatoQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Beverage.CaramelMacchiatoText & " X" & Beverage.CaramelMacchiatoQty)
        End If
        If Beverage.EspressoQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Beverage.EspressoText & " X" & Beverage.EspressoQty)
        End If
        If Beverage.MochaQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Beverage.MochaText & " X" & Beverage.MochaQty)
        End If
        If Beverage.AmericanoQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Beverage.AmericanoText & " X" & Beverage.AmericanoQty)
        End If

        'Frappucino Section
        If Beverage.JavaChipQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Beverage.JavaChipText & " X" & Beverage.JavaChipQty)
        End If
        If Beverage.CaramelFrappQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Beverage.CaramelFrappText & " X" & Beverage.CaramelFrappQty)
        End If
        If Beverage.CaffeVanillaQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Beverage.CaffeVanillaText & " X" & Beverage.CaffeVanillaQty)
        End If
        If Beverage.MochaCookieQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Beverage.MochaCookieText & " X" & Beverage.MochaCookieQty)
        End If
        'Snacks Section
        If Snacks.SandwichQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Snacks.SandwichText & " X" & Snacks.SandwichQty)
        End If
        If Snacks.CroissantQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Snacks.CroissantText & " X" & Snacks.CroissantQty)
        End If
        If Snacks.MuffinQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Snacks.MuffinText & " X" & Snacks.MuffinQty)
        End If
        If Snacks.FrenchFriesQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Snacks.FrenchFriesText & " X" & Snacks.FrenchFriesQty)
        End If
        If Snacks.ToastBreadQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Snacks.ToastBreadText & " X" & Snacks.ToastBreadQty)
        End If
        If Snacks.PastriesQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Snacks.PastriesText & " X" & Snacks.PastriesQty)
        End If

        'Desserts Section
        If Desserts.CarrotCakeQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Desserts.CarrotCakeText & " X" & Desserts.CarrotCakeQty)
        End If
        If Desserts.MoltenCakeQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Desserts.MoltenCakeText & " X" & Desserts.MoltenCakeQty)
        End If
        If Desserts.BananaCakeQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Desserts.BananaCakeText & " X" & Desserts.BananaCakeQty)
        End If
        If Desserts.TiramisuCakeQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Desserts.TiramisuCakeText & " X" & Desserts.TiramisuCakeQty)
        End If
        If Desserts.PancakeQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Desserts.PancakeText & " X" & Desserts.PancakeQty)
        End If
        If Desserts.ApplePieQty > 0 Then
            lstDisplayOrder.Items.Add(vbTab & vbTab & Desserts.ApplePieText & " X" & Desserts.ApplePieQty)
        End If

        lstDisplayOrder.Items.Add("============================================================================")
        lstDisplayOrder.Items.Add("Total Beverage Price: RM" & Beverage.priceBeverage.ToString("N2"))
        lstDisplayOrder.Items.Add("Total Snacks Price: RM" & Snacks.priceSnacks.ToString("N2"))
        lstDisplayOrder.Items.Add("Total Desserts Price: RM" & Desserts.priceDesserts.ToString("N2"))
        lstDisplayOrder.Items.Add("----------------------------------------------------------------------------")
        lstDisplayOrder.Items.Add("Total Price (Before Tax): RM" & totalPrice().ToString("N2"))
        lstDisplayOrder.Items.Add("Tax Price: RM" & Tax().ToString("N2"))
        lstDisplayOrder.Items.Add("============================================================================")
        lstDisplayOrder.Items.Add("TOTAL PRICE: RM" & taxedPrice().ToString("N2"))
    End Sub

    Private Function totalPrice() As Double
        Dim totPrice As Double

        totPrice = Beverage.priceBeverage + Snacks.priceSnacks + Desserts.priceDesserts

        Return totPrice
    End Function

    Private Function taxedPrice() As Double
        Dim TaxTotal As Double

        TaxTotal = totalPrice() + (totalPrice() * 0.05)

        Return TaxTotal
    End Function

    Private Function Tax() As Double
        Dim TaxPrice As Double

        TaxPrice = (totalPrice() * 0.05)

        Return TaxPrice
    End Function

    'File
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim customerPrint As StreamWriter
        Dim customerData As StreamWriter
        Dim currentDate As String = DateTime.Now.ToString("dddd, dd MMMM yyyy")
        Dim currentTime As String = DateTime.Now.ToString("hh:mm tt")
        'Print receipt into text file

        Try
            customerPrint = File.AppendText("customerPrint.txt")

            customerPrint.WriteLine(currentDate)
            customerPrint.WriteLine(currentTime)
            For Each line In Me.lstDisplayOrder.Items
                customerPrint.WriteLine(line)
            Next
            customerPrint.WriteLine(vbNewLine)
            customerPrint.WriteLine(vbNewLine)
            customerPrint.Close()
        Catch ex As FileNotFoundException
            MessageBox.Show("The targeted file error.")
        End Try


        MessageBox.Show("Your order have submitted to the system! You will be returned to the menu page!")



        'Allocate data for summary review
        customerData = File.AppendText("customerData.txt")
        'Beverage Section
        customerData.Write(Beverage.HoneyTeaQty)
        customerData.Write(";")
        customerData.Write(Beverage.GreenTeaQty)
        customerData.Write(";")
        customerData.Write(Beverage.MilkTeaQty)
        customerData.Write(";")
        customerData.Write(Beverage.JasmineTeaQty)
        customerData.Write(";")
        customerData.Write(Beverage.CaramelMacchiatoQty)
        customerData.Write(";")
        customerData.Write(Beverage.EspressoQty)
        customerData.Write(";")
        customerData.Write(Beverage.MochaQty)
        customerData.Write(";")
        customerData.Write(Beverage.AmericanoQty)
        customerData.Write(";")
        customerData.Write(Beverage.JavaChipQty)
        customerData.Write(";")
        customerData.Write(Beverage.CaramelFrappQty)
        customerData.Write(";")
        customerData.Write(Beverage.CaffeVanillaQty)
        customerData.Write(";")
        customerData.Write(Beverage.MochaCookieQty)
        customerData.Write(";")
        'Snacks Section
        customerData.Write(Snacks.SandwichQty)
        customerData.Write(";")
        customerData.Write(Snacks.CroissantQty)
        customerData.Write(";")
        customerData.Write(Snacks.MuffinQty)
        customerData.Write(";")
        customerData.Write(Snacks.FrenchFriesQty)
        customerData.Write(";")
        customerData.Write(Snacks.ToastBreadQty)
        customerData.Write(";")
        customerData.Write(Snacks.PastriesQty)
        customerData.Write(";")
        'Desserts Section
        customerData.Write(Desserts.CarrotCakeQty)
        customerData.Write(";")
        customerData.Write(Desserts.MoltenCakeQty)
        customerData.Write(";")
        customerData.Write(Desserts.BananaCakeQty)
        customerData.Write(";")
        customerData.Write(Desserts.TiramisuCakeQty)
        customerData.Write(";")
        customerData.Write(Desserts.PancakeQty)
        customerData.Write(";")
        customerData.Write(Desserts.ApplePieQty)
        customerData.Write(";")

        'Others Information
        customerData.Write(Beverage.priceBeverage)
        customerData.Write(";")
        customerData.Write(Snacks.priceSnacks)
        customerData.Write(";")
        customerData.Write(Desserts.priceDesserts)
        customerData.Write(";")
        customerData.Write(totalPrice())
        customerData.Write(";")
        customerData.WriteLine(vbNewLine)
        customerData.Close()

        'Set variables and functions to default
        Beverage.HoneyTeaQty = 0
        Beverage.GreenTeaQty = 0
        Beverage.JasmineTeaQty = 0
        Beverage.MilkTeaQty = 0
        Beverage.CaramelMacchiatoQty = 0
        Beverage.EspressoQty = 0
        Beverage.MochaQty = 0
        Beverage.AmericanoQty = 0
        Beverage.CaramelFrappQty = 0
        Beverage.JavaChipQty = 0
        Beverage.CaffeVanillaQty = 0
        Beverage.MochaCookieQty = 0

        Snacks.SandwichQty = 0
        Snacks.CroissantQty = 0
        Snacks.MuffinQty = 0
        Snacks.FrenchFriesQty = 0
        Snacks.ToastBreadQty = 0
        Snacks.PastriesQty = 0

        Desserts.CarrotCakeQty = 0
        Desserts.MoltenCakeQty = 0
        Desserts.BananaCakeQty = 0
        Desserts.TiramisuCakeQty = 0
        Desserts.PancakeQty = 0
        Desserts.ApplePieQty = 0
        'Read Only defaults
        Beverage.txtHoneyQty.ReadOnly = True
        Beverage.txtGreenQty.ReadOnly = True
        Beverage.txtMilkQty.ReadOnly = True
        Beverage.txtJasmineQty.ReadOnly = True
        Beverage.txtCaramelQty.ReadOnly = True
        Beverage.txtEspressoQty.ReadOnly = True
        Beverage.txtMochaQty.ReadOnly = True
        Beverage.txtAmericanoQty.ReadOnly = True
        Beverage.txtCaramelFrappQty.ReadOnly = True
        Beverage.txtJavachipQty.ReadOnly = True
        Beverage.txtVanillaQty.ReadOnly = True
        Beverage.txtCookieQty.ReadOnly = True

        Snacks.txtSandwichQty.ReadOnly = True
        Snacks.txtCroissantQty.ReadOnly = True
        Snacks.txtMuffinQty.ReadOnly = True
        Snacks.txtFriesQty.ReadOnly = True
        Snacks.txtBreadQty.ReadOnly = True
        Snacks.txtPastriesQty.ReadOnly = True

        Desserts.txtCarrotQty.ReadOnly = True
        Desserts.txtMoltenQty.ReadOnly = True
        Desserts.txtBananaQty.ReadOnly = True
        Desserts.txtTiramisuQty.ReadOnly = True
        Desserts.txtPancakeQty.ReadOnly = True
        Desserts.txtAppleQty.ReadOnly = True

        'Checked defaults
        Beverage.chckHoneyTea.Checked = False
        Beverage.chckGreenTea.Checked = False
        Beverage.chckMilkTea.Checked = False
        Beverage.chckJasmineTea.Checked = False
        Beverage.chckCaramel.Checked = False
        Beverage.chckEspresso.Checked = False
        Beverage.chckMocha.Checked = False
        Beverage.chckAmericano.Checked = False
        Beverage.chckCaramelFrapp.Checked = False
        Beverage.chckJavachip.Checked = False
        Beverage.chckVanilla.Checked = False
        Beverage.chckCookie.Checked = False

        Snacks.chckSandwich.Checked = False
        Snacks.chckCroissant.Checked = False
        Snacks.chckMuffin.Checked = False
        Snacks.chckFries.Checked = False
        Snacks.chckBread.Checked = False
        Snacks.chckPastry.Checked = False

        Desserts.chckCarrot.Checked = False
        Desserts.chckMolten.Checked = False
        Desserts.chckBanana.Checked = False
        Desserts.chckTiramisu.Checked = False
        Desserts.chckPancake.Checked = False
        Desserts.chckApple.Checked = False

        'Clear textbox input
        Beverage.txtHoneyQty.Clear()
        Beverage.txtGreenQty.Clear()
        Beverage.txtMilkQty.Clear()
        Beverage.txtJasmineQty.Clear()
        Beverage.txtCaramelQty.Clear()
        Beverage.txtEspressoQty.Clear()
        Beverage.txtMochaQty.Clear()
        Beverage.txtAmericanoQty.Clear()
        Beverage.txtCaramelFrappQty.Clear()
        Beverage.txtJavachipQty.Clear()
        Beverage.txtVanillaQty.Clear()
        Beverage.txtCookieQty.Clear()

        Snacks.txtSandwichQty.Clear()
        Snacks.txtCroissantQty.Clear()
        Snacks.txtMuffinQty.Clear()
        Snacks.txtFriesQty.Clear()
        Snacks.txtBreadQty.Clear()
        Snacks.txtPastriesQty.Clear()

        Desserts.txtCarrotQty.Clear()
        Desserts.txtMoltenQty.Clear()
        Desserts.txtBananaQty.Clear()
        Desserts.txtTiramisuQty.Clear()
        Desserts.txtPancakeQty.Clear()
        Desserts.txtAppleQty.Clear()

        Me.Hide()
        MenuForm.Show()

    End Sub
    Private Sub printReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim pdProducts As New PrintDocument

        Dim titleFont As New Font("Times New Roman", 12, FontStyle.Bold)
        Dim contentFont As New Font("Times New Roman", 12)
        Dim currentPosition As Integer = 100

        ' Store header
        e.Graphics.DrawString("BOX JB CAFE", titleFont, Brushes.Black, 100, currentPosition)
        currentPosition += 20
        e.Graphics.DrawString(" CAFE * SNACKS * DESSERTS ", titleFont, Brushes.Black, 100, currentPosition)
        currentPosition += 40
        e.Graphics.DrawString("20, Jalan Geronggang, Taman Kebun Teh", contentFont, Brushes.Black, 100, currentPosition)
        currentPosition += 20
        e.Graphics.DrawString("80250 Johor Bahru, Johor.", contentFont, Brushes.Black, 100, currentPosition)
        currentPosition += 20
        e.Graphics.DrawString("TEL:  011-3778 1946", contentFont, Brushes.Black, 100, currentPosition)
        currentPosition += 20

        ' Receipt header
        e.Graphics.DrawString("INVOICE RECEIPT:", titleFont, Brushes.Black, 100, currentPosition)

        Dim currentDate As String = DateTime.Now.ToString("dddd, dd MMMM yyyy")
        Dim currentTime As String = DateTime.Now.ToString("hh:mm tt")
        currentPosition += 40

        e.Graphics.DrawString("Date: " & currentDate, contentFont, Brushes.Black, 100, currentPosition)
        currentPosition += 20

        e.Graphics.DrawString("Time: " & currentTime, contentFont, Brushes.Black, 100, currentPosition)
        currentPosition += 20

        If MenuForm.TableNum > 0 Then    'if customer had a table(dine in)
            ' Table number
            e.Graphics.DrawString("Table Number:" & MenuForm.TableNum, titleFont, Brushes.Black, 100, currentPosition)
            currentPosition += 20
        End If

        e.Graphics.DrawString("===================================================================", contentFont, Brushes.Black, 100, currentPosition)
        currentPosition += 20

        Dim orderDetails As List(Of String) = New List(Of String)()

        If Beverage.HoneyTeaQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Beverage.HoneyTeaText & " X" & Beverage.HoneyTeaQty)
        End If
        If Beverage.GreenTeaQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Beverage.GreenTeaText & " X" & Beverage.GreenTeaQty)
        End If
        If Beverage.MilkTeaQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Beverage.MilkTeaText & " X" & Beverage.MilkTeaQty)
        End If
        If Beverage.JasmineTeaQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Beverage.JasmineTeaText & " X" & Beverage.JasmineTeaQty)
        End If

        'Coffee Section
        If Beverage.CaramelMacchiatoQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Beverage.CaramelMacchiatoText & " X" & Beverage.CaramelMacchiatoQty)
        End If
        If Beverage.EspressoQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Beverage.EspressoText & " X" & Beverage.EspressoQty)
        End If
        If Beverage.MochaQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Beverage.MochaText & " X" & Beverage.MochaQty)
        End If
        If Beverage.AmericanoQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Beverage.AmericanoText & " X" & Beverage.AmericanoQty)
        End If

        'Frappucino Section
        If Beverage.JavaChipQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Beverage.JavaChipText & " X" & Beverage.JavaChipQty)
        End If
        If Beverage.CaramelFrappQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Beverage.CaramelFrappText & " X" & Beverage.CaramelFrappQty)
        End If
        If Beverage.CaffeVanillaQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Beverage.CaffeVanillaText & " X" & Beverage.CaffeVanillaQty)
        End If
        If Beverage.MochaCookieQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Beverage.MochaCookieText & " X" & Beverage.MochaCookieQty)
        End If
        'Snacks Section
        If Snacks.SandwichQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Snacks.SandwichText & " X" & Snacks.SandwichQty)
        End If
        If Snacks.CroissantQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Snacks.CroissantText & " X" & Snacks.CroissantQty)
        End If
        If Snacks.MuffinQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Snacks.MuffinText & " X" & Snacks.MuffinQty)
        End If
        If Snacks.FrenchFriesQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Snacks.FrenchFriesText & " X" & Snacks.FrenchFriesQty)
        End If
        If Snacks.ToastBreadQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Snacks.ToastBreadText & " X" & Snacks.ToastBreadQty)
        End If
        If Snacks.PastriesQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Snacks.PastriesText & " X" & Snacks.PastriesQty)
        End If

        'Desserts Section
        If Desserts.CarrotCakeQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Desserts.CarrotCakeText & " X" & Desserts.CarrotCakeQty)
        End If
        If Desserts.MoltenCakeQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Desserts.MoltenCakeText & " X" & Desserts.MoltenCakeQty)
        End If
        If Desserts.BananaCakeQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Desserts.BananaCakeText & " X" & Desserts.BananaCakeQty)
        End If
        If Desserts.TiramisuCakeQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Desserts.TiramisuCakeText & " X" & Desserts.TiramisuCakeQty)
        End If
        If Desserts.PancakeQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Desserts.PancakeText & " X" & Desserts.PancakeQty)
        End If
        If Desserts.ApplePieQty > 0 Then
            orderDetails.Add(vbTab & vbTab & Desserts.ApplePieText & " X" & Desserts.ApplePieQty)
        End If

        ' Print order details dynamically
        ' Order details

        e.Graphics.DrawString("Your Order:", titleFont, Brushes.Black, 100, currentPosition)
        currentPosition += 20

        For Each orderItem As String In orderDetails
            e.Graphics.DrawString(orderItem, contentFont, Brushes.Black, 100, currentPosition)
            currentPosition += 20
        Next

        currentPosition += 20

        e.Graphics.DrawString("===================================================================", contentFont, Brushes.Black, 100, currentPosition)
        currentPosition += 20

        'Payment Details
        e.Graphics.DrawString("Subtotal:" & vbTab & vbTab & totalPrice().ToString("C2"), contentFont, Brushes.Black, 100, currentPosition)
        currentPosition += 20
        e.Graphics.DrawString("Service Tax (6%): " & vbTab & Tax().ToString("C2"), contentFont, Brushes.Black, 100, currentPosition)
        currentPosition += 40
        e.Graphics.DrawString("TOTAL:" & vbTab & taxedPrice.ToString("C2"), titleFont, Brushes.Black, 100, currentPosition)
        currentPosition += 20
        e.Graphics.DrawString("===================================================================", contentFont, Brushes.Black, 100, currentPosition)
        currentPosition += 20

        ' Move currentPosition to the bottom of the page
        currentPosition = e.MarginBounds.Height - 50 ' Adjust as needed

        ' Thank You message at the bottom
        e.Graphics.DrawString("Thank You for Dining With Us!", titleFont, Brushes.Black, e.MarginBounds.Width / 4, currentPosition)
        currentPosition += 20 ' Adjust spacing

        ' Additional styling for the "Thank You" message
        Dim customFontStyle As New Font("Times New Roman", 16, FontStyle.Italic Or FontStyle.Underline)
        e.Graphics.DrawString("Your satisfaction is our priority.", customFontStyle, Brushes.Black, e.MarginBounds.Width / 4, currentPosition)
        currentPosition += 20 ' Adjust spacing

        ' Additional styling for the "Thank You" message
        e.Graphics.DrawString("We hope to serve you again soon!", customFontStyle, Brushes.Black, e.MarginBounds.Width / 4, currentPosition)
        currentPosition += 20 ' Adjust spacing


    End Sub

    Private Sub btnDesserts_Click(sender As Object, e As EventArgs) Handles btnDesserts.Click
        Me.Hide()
        Desserts.Show()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.Print()
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Checkout_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
