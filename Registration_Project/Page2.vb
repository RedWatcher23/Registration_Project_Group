Public Class Page2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn3.Click

        Dim nextMain As New Form1()
        Form1.Show()

        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn1.Click

        Dim nextSRI As New SRI1()
        SRI1.Show()
        Me.Hide()

    End Sub
End Class