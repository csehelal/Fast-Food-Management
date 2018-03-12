Public Class FirstCustomerControl

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Details As Details = New Details
        Details.Show()
        Details.StartPosition = FormStartPosition.CenterParent


    End Sub
End Class
