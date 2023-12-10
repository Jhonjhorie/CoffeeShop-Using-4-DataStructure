Public Class PendingOrders

    Private ReadOnly orderQueue As New Queue(Of String)()
    Public Sub AddOrderToQueue(order As String)
        orderQueue.Enqueue(order)

        UpdateOrderQueueUI()
    End Sub

    Private Sub UpdateOrderQueueUI()
        OrderQueueListBox.Items.Clear()
        For Each order In orderQueue
            OrderQueueListBox.Items.Add(order)
        Next
    End Sub

    Private Sub btnPushTea_Click(sender As Object, e As EventArgs) Handles btnPushTea.Click
        Me.Close()
    End Sub

End Class
