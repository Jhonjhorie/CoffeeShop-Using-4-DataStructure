Public Class Form1


    ' -------------------Linked List DataStructure-------------------
    Public Class Node
        Public Property Value As String
        Public Property NextNode As Node

        Public Sub New(value As String)
            Me.Value = value
            Me.NextNode = Nothing
        End Sub
    End Class



    Private categories As Node() = {Nothing, Nothing, Nothing}

    Private Sub InitializeCategories()
        ' Coffee
        categories(0) = New Node("Americano")
        categories(0).NextNode = New Node("Cappuccino")
        categories(0).NextNode.NextNode = New Node("Latte")
        categories(0).NextNode.NextNode.NextNode = New Node("Espresso")
        categories(0).NextNode.NextNode.NextNode.NextNode = New Node("Mocha")

        ' Tea
        categories(1) = New Node("Green Tea")
        categories(1).NextNode = New Node("Chamomile Tea")
        categories(1).NextNode.NextNode = New Node("Peppermint Tea")
        categories(1).NextNode.NextNode.NextNode = New Node("Earl Grey Tea")
        categories(1).NextNode.NextNode.NextNode.NextNode = New Node("Jasmine Tea")

        ' Pastries
        categories(2) = New Node("Croissant")
        categories(2).NextNode = New Node("Muffin")
        categories(2).NextNode.NextNode = New Node("Cookies")
        categories(2).NextNode.NextNode.NextNode = New Node("Cinnamon")
        categories(2).NextNode.NextNode.NextNode.NextNode = New Node("Fruit Tart")
    End Sub

    Private Sub AddItemsToListBox(categoryIndex As Integer, listBox As ListBox)
        Dim current As Node = categories(categoryIndex)
        While current IsNot Nothing
            listBox.Items.Add(current.Value)
            current = current.NextNode
        End While
    End Sub
    ' -------------------End of Linked List DataStructure-------------------






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeCategories()

        AddItemsToListBox(0, CoffeesListBox)
        AddItemsToListBox(1, TeaListBox)
        AddItemsToListBox(2, PastriesListBox)
    End Sub

    Public DineOrOut As String = ""

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdDinein.CheckedChanged
        UpdateOrderTypeLabel(rdDinein, "Dine In")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdTakeout.CheckedChanged
        UpdateOrderTypeLabel(rdTakeout, "Take Out")
    End Sub

    Private Sub UpdateOrderTypeLabel(selectedRadioButton As RadioButton, orderType As String)
        If selectedRadioButton.Checked Then
            DineOrOut = orderType
            If selectedRadioButton Is rdDinein Then
                rdTakeout.Checked = False
            ElseIf selectedRadioButton Is rdTakeout Then
                rdDinein.Checked = False
            End If
        Else
            DineOrOut = "Please Select again"
        End If
    End Sub

    Private CoffeePrice As Decimal = 0.00
    Private TeaPrice As Decimal = 0.00
    Dim PastryPrice As Decimal = 0.0

    Private TotalPrice As Decimal = 0.00

    Private Sub SizeCListbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SizeCListbox.SelectedIndexChanged
        Dim selectedSize As String = GetSelectedValue(SizeCListbox)

        Select Case selectedSize
            Case "S"
                CoffeePrice = 299.0
            Case "M"
                CoffeePrice = 399.0
            Case "L"
                CoffeePrice = 499.0
            Case "XL"
                CoffeePrice = 599.0
        End Select

        lblCoffeePrice.Text = CoffeePrice.ToString("C", New Globalization.CultureInfo("en-PH"))
    End Sub

    Private Sub SizeTListbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SizeTListbox.SelectedIndexChanged
        Dim selectedSize As String = GetSelectedValue(SizeTListbox)

        Select Case selectedSize
            Case "S"
                TeaPrice = 99.0
            Case "M"
                TeaPrice = 149.0
            Case "L"
                TeaPrice = 199.0
            Case "XL"
                TeaPrice = 249.0
        End Select
        lblTeaPrice.Text = TeaPrice.ToString("C", New Globalization.CultureInfo("en-PH"))

    End Sub
    Private Sub btnPushtoOrder_Click(sender As Object, e As EventArgs) Handles btnPushtoOrder.Click
        Dim HotOrIced As String = GetHotOrIced(rdCHot, rdCIced)
        Dim Coffee As String = GetSelectedValue(CoffeesListBox)
        Dim Size As String = GetSelectedValue(SizeCListbox)

        If String.IsNullOrEmpty(Coffee) Then
            MessageBox.Show("Please select a Coffee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If HotOrIced = "Unknown" Then
            MessageBox.Show("Please select Hot or Iced for the Coffee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        TotalPrice += CoffeePrice
        lblTotal.Text = TotalPrice.ToString("C", New Globalization.CultureInfo("en-PH"))
        AddOrderToSummary($"{HotOrIced} {Coffee}, {Size}")
    End Sub

    Private Sub btnPushTea_Click(sender As Object, e As EventArgs) Handles btnPushTea.Click
        Dim HotOrIced As String = GetHotOrIced(rdTHot, rdTIced)
        Dim Tea As String = GetSelectedValue(TeaListBox)
        Dim Size As String = GetSelectedValue(SizeTListbox)

        If String.IsNullOrEmpty(Tea) Then
            MessageBox.Show("Please select a Tea.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If HotOrIced = "Unknown" Then
            MessageBox.Show("Please select Hot or Iced for the Tea.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        TotalPrice += TeaPrice
        lblTotal.Text = TotalPrice.ToString("C", New Globalization.CultureInfo("en-PH"))
        AddOrderToSummary($"{HotOrIced} {Tea}, {Size}")
    End Sub

    Private Sub btnPushPastry_Click(sender As Object, e As EventArgs) Handles btnPushPastry.Click
        Dim Pastries As String = GetSelectedValue(PastriesListBox)

        If String.IsNullOrEmpty(Pastries) Then
            MessageBox.Show("Please select a Pastry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        TotalPrice += PastryPrice
        lblTotal.Text = TotalPrice.ToString("C", New Globalization.CultureInfo("en-PH"))
        AddOrderToSummary($"{Pastries}")
    End Sub



    Private Function GetHotOrIced(hotRadioButton As RadioButton, icedRadioButton As RadioButton) As String
        If hotRadioButton.Checked Then
            hotRadioButton.Checked = False
            Return "Hot"
        ElseIf icedRadioButton.Checked Then
            icedRadioButton.Checked = False
            Return "Iced"
        Else
            Return "Unknown"
        End If
    End Function




    ' -------------------Stack DataStructure-------------------

    Private orderSummaryStack As New LinkedList(Of String)

    Private Sub AddOrderToSummary(orderSummary As String)
        orderSummaryStack.AddLast(orderSummary)
        UpdateOrderSummaryListBox()
    End Sub
    Private Sub UpdateOrderSummaryListBox()
        OrdersummaryListBox.Items.Clear()
        For Each item In orderSummaryStack
            OrdersummaryListBox.Items.Add(item)
        Next
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        If orderSummaryStack.Count > 0 Then
            orderSummaryStack.RemoveLast()
            UpdateOrderSummaryListBox()
        End If
    End Sub

    ' -------------------EndStack DataStructure-------------------





    Private Function GetSelectedValue(listBox As ListBox) As String
        Return If(listBox.SelectedIndex <> -1, listBox.SelectedItem.ToString(), "")
    End Function

    Private Sub btnOrderHistory_Click(sender As Object, e As EventArgs) Handles btnOrderHistory.Click
        Dim orderHistoryForm As New OrderHistory()
        orderHistoryForm.Show()
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        Dim CustomerQueuesForm As New CustomerQueues()
        CustomerQueuesForm.Show()
    End Sub
    Private Shared orderCounter As Integer = 1




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clear()
    End Sub
    Private Sub Clear()
        CoffeesListBox.ClearSelected()
        TeaListBox.ClearSelected()
        PastriesListBox.ClearSelected()
        SizeCListbox.ClearSelected()
        SizeTListbox.ClearSelected()

        OrdersummaryListBox.Items.Clear()
        txtcustomername.Text = ""
        txtCashTendered.Text = ""
        lblChange.Text = "0"
        lblTotal.Text = "0"

        rdCHot.Checked = False
        rdCIced.Checked = False
        rdTHot.Checked = False
        rdTIced.Checked = False
        rdTakeout.Checked = False
        rdDinein.Checked = False
    End Sub

    Private Sub CoffeesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CoffeesListBox.SelectedIndexChanged
        If CoffeesListBox.SelectedIndex <> -1 Then
            Dim selectedItem As String = CoffeesListBox.SelectedItem.ToString()

            Dim imagePath As String = "C:\\Users\\jhonj\\source\\repos\\CoffeeShop(DataStracture)\\CoffeeShop(DataStracture)\\Pictures\\"

            Select Case selectedItem
                Case "Americano"
                    imgCoffee.BackgroundImage = New Bitmap(imagePath & "Americano.png")
                    lblCoffeeName.Text = "Americano"

                Case "Cappuccino"
                    imgCoffee.BackgroundImage = New Bitmap(imagePath & "Cappuccino.png")
                    lblCoffeeName.Text = "Cappuccino"
                Case "Latte"
                    imgCoffee.BackgroundImage = New Bitmap(imagePath & "Latte.png")
                    lblCoffeeName.Text = "Latte"
                Case "Espresso"
                    imgCoffee.BackgroundImage = New Bitmap(imagePath & "Espresso.png")
                    lblCoffeeName.Text = "Espresso"
                Case "Mocha"
                    imgCoffee.BackgroundImage = New Bitmap(imagePath & "Mocha.png")
                    lblCoffeeName.Text = "Mocha"
                Case Else
                    imgCoffee.BackgroundImage = Nothing
            End Select
        Else
            imgCoffee.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub TeaListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TeaListBox.SelectedIndexChanged

        If TeaListBox.SelectedIndex <> -1 Then
            Dim selectedItem As String = TeaListBox.SelectedItem.ToString()

            Dim imagePath As String = "C:\\Users\\jhonj\\source\\repos\\CoffeeShop(DataStracture)\\CoffeeShop(DataStracture)\\Pictures\\"

            Select Case selectedItem
                Case "Green Tea"
                    imgTea.BackgroundImage = New Bitmap(imagePath & "GreenTea.png")
                    lblTeaName.Text = "Green Tea"

                Case "Chamomile Tea"
                    imgTea.BackgroundImage = New Bitmap(imagePath & "Chamomile.png")
                    lblTeaName.Text = "Chamomile Tea"

                Case "Peppermint Tea"
                    imgTea.BackgroundImage = New Bitmap(imagePath & "Peppermint.png")
                    lblTeaName.Text = "Peppermint Tea"

                Case "Earl Grey Tea"
                    imgTea.BackgroundImage = New Bitmap(imagePath & "EarlGrey.png")
                    lblTeaName.Text = "Earl Grey Tea"

                Case "Jasmine Tea"
                    imgTea.BackgroundImage = New Bitmap(imagePath & "Jasmine.png")
                    lblTeaName.Text = "Jasmine Tea"
                Case Else
                    imgTea.BackgroundImage = Nothing
            End Select
        Else
            imgTea.BackgroundImage = Nothing
        End If
    End Sub
    Private Sub PastriesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PastriesListBox.SelectedIndexChanged
        If PastriesListBox.SelectedIndex <> -1 Then
            Dim selectedItem As String = PastriesListBox.SelectedItem.ToString()

            Dim imagePath As String = "C:\\Users\\jhonj\\source\\repos\\CoffeeShop(DataStracture)\\CoffeeShop(DataStracture)\\Pictures\\"


            Select Case selectedItem
                Case "Croissant"
                    imgPastries.BackgroundImage = New Bitmap(imagePath & "Croissant.png")
                    lblPastryName.Text = "Croissant"
                    PastryPrice = 399.0

                Case "Muffin"
                    imgPastries.BackgroundImage = New Bitmap(imagePath & "Muffin.png")
                    lblPastryName.Text = "Muffin"
                    PastryPrice = 299.0

                Case "Cookies"
                    imgPastries.BackgroundImage = New Bitmap(imagePath & "Cookie.png")
                    lblPastryName.Text = "Cookies"
                    PastryPrice = 199.0

                Case "Cinnamon"
                    imgPastries.BackgroundImage = New Bitmap(imagePath & "Cinnamon.png")
                    lblPastryName.Text = "Cinnamon"
                    PastryPrice = 149.0

                Case "Fruit Tart"
                    imgPastries.BackgroundImage = New Bitmap(imagePath & "FruitTart.png")
                    lblPastryName.Text = "Fruit Tart"
                    PastryPrice = 249.0

                Case Else
                    imgPastries.BackgroundImage = Nothing
            End Select

            ' Display the price
            lblPastryPrice.Text = PastryPrice.ToString("C", New Globalization.CultureInfo("en-PH"))
        Else
            imgPastries.BackgroundImage = Nothing
            lblPastryPrice.Text = ""
        End If
    End Sub


    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnCalculateChange.Click
        Dim CustomerCash As Decimal
        Dim Total As Decimal

        Total = TotalPrice

        If Decimal.TryParse(txtCashTendered.Text, CustomerCash) Then
            If CustomerCash >= Total Then
                Dim Change As Decimal = CustomerCash - Total

                lblChange.Text = Change.ToString("C", New Globalization.CultureInfo("en-PH"))
            Else
                MessageBox.Show("Insufficient cash provided. Please provide enough cash to cover the total amount.")
            End If
        Else
            MessageBox.Show("Invalid cash amount. Please enter a valid numeric value.")
        End If
    End Sub





    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If String.IsNullOrWhiteSpace(txtcustomername.Text) Then
            MessageBox.Show("Please enter customer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If OrdersummaryListBox.Items.Count = 0 Then
            MessageBox.Show("Please add items to the order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(DineOrOut) Then
            MessageBox.Show("Please select Dine-in or Takeout.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim PendingOrdersForm As New PendingOrders()
        Dim CustomerQueuesForm As New CustomerQueues()

        With PendingOrdersForm
            .LblCustname.Text = txtcustomername.Text
            .lbloutorin.Text = DineOrOut

            For Each item As Object In OrdersummaryListBox.Items
                .AddOrderToQueue(item.ToString())
            Next

            .lblQuenumber.Text = orderCounter.ToString()

            orderCounter += 1
        End With

        PendingOrdersForm.Show()
        Clear()
    End Sub

End Class
