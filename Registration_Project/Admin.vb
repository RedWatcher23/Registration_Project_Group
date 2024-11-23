Public Class Admin
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim nextPayment As New Page2()
        PaymentUpdate.Show()

        Me.Hide()
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim nextSrs As New Page2()
        SRS.Show()

        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Dim nextMain As New Page2()
        Form1.Show()

        Me.Hide()
    End Sub
End Class