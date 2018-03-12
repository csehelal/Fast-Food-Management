Public Class Form1

    Public Sub New()
        Me.InitializeComponent()
        FirstCustomerControl1.BringToFront()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SidePanel.Height = Button1.Height()
        FirstCustomerControl1.BringToFront()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SidePanel.Height = Button2.Height()
        MySecondCustomerControl1.BringToFront()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SidePanel.Height = Button3.Height()
        CollectionCustomer1.BringToFront()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SidePanel.Height = Button4.Height()
        MySecondCustomerControl1.BringToFront()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SidePanel.Height = Button5.Height()
        MySecondCustomerControl1.BringToFront()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SidePanel.Height = Button6.Height()
        MySecondCustomerControl1.BringToFront()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SidePanel.Height = Button7.Height()
        MySecondCustomerControl1.BringToFront()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Application.Exit()
    End Sub
End Class
