Public Class OrderHistory

    Private items As New List(Of String) From {"Syrel", "John", "Luigi", "Shanlee", "Eunice", "Maria"}

    Private Sub OrderHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        items.Sort()

        PopulateListBox(items)
    End Sub

    Private Sub PopulateListBox(data As List(Of String))
        lstItems.Items.Clear()

        lstItems.Items.AddRange(data.ToArray())
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        Dim filterText As String = txtFilter.Text.ToLower()

        Dim startIndex = BinarySearch(items, filterText)

        Dim filteredItems = items.Skip(startIndex).Where(Function(item) item.ToLower().Contains(filterText)).ToList()

        PopulateListBox(filteredItems)
    End Sub

    Private Function BinarySearch(data As List(Of String), target As String) As Integer
        Dim low As Integer = 0
        Dim high As Integer = data.Count - 1

        While low <= high
            Dim mid As Integer = (low + high) \ 2
            Dim comparisonResult As Integer = String.Compare(data(mid).ToLower(), target)

            If comparisonResult = 0 Then
                Return mid
            ElseIf comparisonResult < 0 Then
                low = mid + 1
            Else
                high = mid - 1
            End If
        End While
        Return low
    End Function
End Class