Imports System.Collections.Generic

Public Class CustomerQueues
    ' Define a class to represent an order
    Public Class Order
        Public Property OrderNumber As Integer
        Public Property OrderDetails As String

        Public Sub New(orderNumber As Integer, orderDetails As String)
            Me.OrderNumber = orderNumber
            Me.OrderDetails = orderDetails
        End Sub

        Public Overrides Function ToString() As String
            Return $"Order {OrderNumber}: {OrderDetails}"
        End Function
    End Class

    ' Queue to manage orders
    Private ReadOnly orderQueue As New Queue(Of Order)()
    Private orderCounter As Integer = 1

    Private Sub btnNextQueue_Click(sender As Object, e As EventArgs) Handles btnNextQueue.Click
        ' Check if there are orders in the queue
        If orderQueue.Count > 0 Then
            ' Get and remove the next order from the queue
            Dim nextOrder As Order = orderQueue.Dequeue()

            ' Display the order in the ListBox
            QueueListbox.Items.Add(nextOrder.ToString())
        Else
            ' If the queue is empty, display a message
            MessageBox.Show("No more orders in the queue.", "Queue Empty", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Method to add an order to the queue
    Public Sub AddOrderToQueue(orderDetails As String)
        Dim newOrder As New Order(orderCounter, orderDetails)
        orderQueue.Enqueue(newOrder)
        orderCounter += 1
    End Sub
End Class
