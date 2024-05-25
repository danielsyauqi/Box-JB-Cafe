Imports System.IO

Public Class Summary
    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        Dim data() As String
        Dim totBeverage As Double
        Dim totSnacks As Double
        Dim totDesserts As Double
        Dim totalPrice As Double
        Dim TeaQty, CoffeeQty, FrappQty, SnacksQty, DessertsQty As Integer
        Dim BeverageArr() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim BeverageName() As String = {"Honey Tea", "GreenTea", "Milk Tea", "Jasmine Tea", "Caramel Macchiato", "Espresso", "Mocha", "Americano", "Java Chip Frappucino", "Caramel Frappucino", "Caffe Vanilla Frappucino", "Mocha Cookies Frappucino"}
        Dim SnacksArr() As Integer = {0, 0, 0, 0, 0, 0}
        Dim SnacksName() As String = {"Sandwich", "Croissant", "Muffin", "French Fries", "Toast Bread", "Pastries"}
        Dim DessertsArr() As Integer = {0, 0, 0, 0, 0, 0}
        Dim DessertsName() As String = {"Carrot Cake", "Molten Choco Cake", "Banana Cream Pie", "Tiramisu", "Pancake", "Apple Pie"}

        Dim scan As String() = System.IO.File.ReadAllLines("customerData.txt")
        For Each lines As String In scan
            data = lines.Split(";")

            For i As Integer = 0 To 11
                BeverageArr(i) += Val(data(i))
            Next

            Dim index As Integer = 0
            For i As Integer = 12 To 17
                SnacksArr(index) += Val(data(i))
                index += 1
            Next

            Dim index2 As Integer = 0
            For i As Integer = 18 To 23
                DessertsArr(index2) += Val(data(i))
                index2 += 1
            Next

            totBeverage += Val(data(24))
            totSnacks += Val(data(25))
            totDesserts += Val(data(26))
            totalPrice += Val(data(27))

        Next

        'Beverage Quanity
        For i As Integer = 0 To 3
            TeaQty += BeverageArr(i)
        Next

        For i As Integer = 4 To 7
            CoffeeQty += BeverageArr(i)
        Next

        For i As Integer = 8 To 11
            FrappQty += BeverageArr(i)
        Next

        'Snacks Quantity
        For i As Integer = 0 To 5
            SnacksQty += SnacksArr(i)
        Next

        'Desserts Quantity
        For i As Integer = 0 To 5
            DessertsQty += DessertsArr(i)
        Next

        Dim HighestNumBeverage As Integer = BeverageArr.Max()
        Dim HighestNumSnacks As Integer = SnacksArr.Max()
        Dim HighestNumDesserts As Integer = DessertsArr.Max()
        Dim LowestNumBeverage As Integer = BeverageArr.Min()
        Dim LowestNumSnacks As Integer = SnacksArr.Min()
        Dim LowestNumDesserts As Integer = DessertsArr.Min()

        lstDisplaySummary.Items.Add("===================================================================")
        lstDisplaySummary.Items.Add(vbTab & vbTab & "SALES REPORT (BOX JB CAFE)")
        lstDisplaySummary.Items.Add("===================================================================")
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add("---------------------------------------")
        lstDisplaySummary.Items.Add(vbTab & "BEVERAGES")
        lstDisplaySummary.Items.Add("---------------------------------------")
        lstDisplaySummary.Items.Add("(TEA)")
        lstDisplaySummary.Items.Add(vbTab & "Honey Tea = X" & BeverageArr(0))
        lstDisplaySummary.Items.Add(vbTab & "Green Tea = X" & BeverageArr(1))
        lstDisplaySummary.Items.Add(vbTab & "Milk Tea = X" & BeverageArr(2))
        lstDisplaySummary.Items.Add(vbTab & "Jasmine Tea = X" & BeverageArr(3))
        lstDisplaySummary.Items.Add("***************************************")
        lstDisplaySummary.Items.Add(vbTab & "Total Tea Sold= X" & TeaQty)
        lstDisplaySummary.Items.Add("***************************************")
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add("(COFFEE)")
        lstDisplaySummary.Items.Add(vbTab & "Caramel Macchiato = X" & BeverageArr(4))
        lstDisplaySummary.Items.Add(vbTab & "Espresso = X" & BeverageArr(5))
        lstDisplaySummary.Items.Add(vbTab & "Mocha = X" & BeverageArr(6))
        lstDisplaySummary.Items.Add(vbTab & "Americano = X" & BeverageArr(7))
        lstDisplaySummary.Items.Add("***************************************")
        lstDisplaySummary.Items.Add(vbTab & "Total Coffee Sold= X" & CoffeeQty)
        lstDisplaySummary.Items.Add("***************************************")
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add("(FRAPPUCINO)")
        lstDisplaySummary.Items.Add("---------------------------------------")
        lstDisplaySummary.Items.Add(vbTab & "Java Chip Frappucino = X" & BeverageArr(8))
        lstDisplaySummary.Items.Add(vbTab & "Caramel Frappucino = X" & BeverageArr(9))
        lstDisplaySummary.Items.Add(vbTab & "Caffe Vanilla Frappucino = X" & BeverageArr(10))
        lstDisplaySummary.Items.Add(vbTab & "Mocha Cookies Frappucino = X" & BeverageArr(11))
        lstDisplaySummary.Items.Add("***************************************")
        lstDisplaySummary.Items.Add(vbTab & "Total Frappucino Sold= X" & FrappQty)
        lstDisplaySummary.Items.Add("***************************************")
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add("---------------------------------------")
        lstDisplaySummary.Items.Add(vbTab & "SNACKS")
        lstDisplaySummary.Items.Add("---------------------------------------")
        lstDisplaySummary.Items.Add(vbTab & "Sandwich = X" & SnacksArr(0))
        lstDisplaySummary.Items.Add(vbTab & "Croissant = X" & SnacksArr(1))
        lstDisplaySummary.Items.Add(vbTab & "Muffin = X" & SnacksArr(2))
        lstDisplaySummary.Items.Add(vbTab & "French Fries = X" & SnacksArr(3))
        lstDisplaySummary.Items.Add(vbTab & "Toast Bread = X" & SnacksArr(4))
        lstDisplaySummary.Items.Add(vbTab & "Pastries = X" & SnacksArr(5))
        lstDisplaySummary.Items.Add("***************************************")
        lstDisplaySummary.Items.Add(vbTab & "Total Snacks Sold= X" & SnacksQty)
        lstDisplaySummary.Items.Add("***************************************")
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add("---------------------------------------")
        lstDisplaySummary.Items.Add(vbTab & "DESSERTS")
        lstDisplaySummary.Items.Add("---------------------------------------")
        lstDisplaySummary.Items.Add(vbTab & "Carrot Cake = X" & DessertsArr(0))
        lstDisplaySummary.Items.Add(vbTab & "Molten Choco Cake = X" & DessertsArr(1))
        lstDisplaySummary.Items.Add(vbTab & "Banana Cream Pie = X" & DessertsArr(2))
        lstDisplaySummary.Items.Add(vbTab & "Tiramisu = X" & DessertsArr(3))
        lstDisplaySummary.Items.Add(vbTab & "Pancake = X" & DessertsArr(4))
        lstDisplaySummary.Items.Add(vbTab & "Apple Pie = X" & DessertsArr(5))
        lstDisplaySummary.Items.Add("***************************************")
        lstDisplaySummary.Items.Add(vbTab & "Total Snacks Sold= X" & DessertsQty)
        lstDisplaySummary.Items.Add("***************************************")
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add("*******************************************************************")
        For i As Integer = 0 To 3
            If BeverageArr(i) = HighestNumBeverage Then
                lstDisplaySummary.Items.Add("Best-Selling Beverage: " & BeverageName(i) & "with total " & BeverageArr(i) & "cup have been sold.")
            End If
        Next

        For i As Integer = 0 To 3
            If SnacksArr(i) = HighestNumSnacks Then
                lstDisplaySummary.Items.Add("Best-Selling Snacks: " & SnacksName(i) & "with total " & SnacksArr(i) & "pieces have been sold.")
            End If
        Next

        For i As Integer = 0 To 3
            If DessertsArr(i) = HighestNumDesserts Then
                lstDisplaySummary.Items.Add("Best-Selling Desserts: " & DessertsName(i) & "with total " & DessertsArr(i) & "pieces have been sold.")
            End If
        Next

        For i As Integer = 0 To 3
            If BeverageArr(i) = LowestNumBeverage Then
                lstDisplaySummary.Items.Add("Least-Selling Beverage: " & BeverageName(i) & "with total " & BeverageArr(i) & "cup have been sold.")
            End If
        Next

        For i As Integer = 0 To 3
            If SnacksArr(i) = LowestNumSnacks Then
                lstDisplaySummary.Items.Add("Least-Selling Snacks: " & SnacksName(i) & "with total " & SnacksArr(i) & "pieces have been sold.")
            End If
        Next

        For i As Integer = 0 To 3
            If DessertsArr(i) = LowestNumDesserts Then
                lstDisplaySummary.Items.Add("Least-Selling Desserts: " & DessertsName(i) & "with total " & DessertsArr(i) & "pieces have been sold.")
            End If
        Next


        lstDisplaySummary.Items.Add("*******************************************************************")
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add(vbNewLine)
        lstDisplaySummary.Items.Add("===================================================================")
        lstDisplaySummary.Items.Add(vbTab & "TOTAL GROSS PROFIT (BEVERAGE) = RM" & totBeverage.ToString("N2"))
        lstDisplaySummary.Items.Add(vbTab & "TOTAL GROSS PROFIT (SNACKS) = RM" & totSnacks.ToString("N2"))
        lstDisplaySummary.Items.Add(vbTab & "TOTAL GROSS PROFIT (DESSERTS) = RM" & totDesserts.ToString("N2"))
        lstDisplaySummary.Items.Add("===================================================================")
        lstDisplaySummary.Items.Add(vbTab & "TOTAL GROSS PROFIT = RM" & totalPrice.ToString("N2"))
        lstDisplaySummary.Items.Add("===================================================================")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        System.IO.File.WriteAllLines("customerData.txt", "")
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        MenuForm.Show()
    End Sub

    Private Sub StaffTable_Click(sender As Object, e As EventArgs) Handles StaffTable.Click
        Me.Hide()
        StaffForm.Show()
    End Sub

    Private Sub Summary_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class