Public Class SRI1
    ' Form Load Event - Set placeholders for all textboxes
    Private Sub SRI1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentRegistrationWalkinDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.StudentRegistrationWalkinDataSet.Table1)
        SetPlaceholder(TextSurName, "Sur Name")
        SetPlaceholder(TextName, "First Name")
        SetPlaceholder(TextMidName, "Middle Name")
        SetPlaceholder(TextDateBirth, "YYYY-MM-DD")
        SetPlaceholder(TextAge, "---")
        SetPlaceholder(TextContact1, "09 ")
        SetPlaceholder(TextPlaceOfBirth, "---")
        SetPlaceholder(TextNationality, "---")
        SetPlaceholder(TextHomeAdd, "Permanent Address")

        SetPlaceholder(TextFarthersName, "Full Name")
        SetPlaceholder(TextFathersBirth, "---")
        SetPlaceholder(TextFathersContact, "09")
        SetPlaceholder(TextFathersEmail, "---")
        SetPlaceholder(TextFathersOccu, "---")

        SetPlaceholder(TextMothersName, "Full Name")
        SetPlaceholder(TextMothersContact, "09")
        SetPlaceholder(TextMothersBirth, "---")
        SetPlaceholder(TextMotherOccu, "---")
        SetPlaceholder(TextMotherEmail, "---")

    End Sub

    ' TextBox Enter Event - Clear placeholder on focus
    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextSurName.Enter, TextName.Enter, TextMidName.Enter,
        TextDateBirth.Enter, TextAge.Enter, TextContact1.Enter, TextPlaceOfBirth.Enter, TextNationality.Enter, TextHomeAdd.Enter,
        TextFarthersName.Enter, TextFathersBirth.Enter, TextFathersContact.Enter, TextFathersEmail.Enter, TextFathersOccu.Enter,
        TextMothersName.Enter, TextMothersContact.Enter, TextMothersBirth.Enter, TextMotherOccu.Enter, TextMotherEmail.Enter
        Dim txt As TextBox = DirectCast(sender, TextBox)
        If txt.ForeColor = Color.Gray Then
            txt.Text = ""
            txt.ForeColor = Color.Black
        End If
    End Sub

    ' TextBox Leave Event - Restore placeholder if empty
    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles TextSurName.Leave, TextName.Leave, TextMidName.Leave, TextDateBirth.Leave,
            TextAge.Leave, TextContact1.Leave, TextPlaceOfBirth.Leave, TextNationality.Leave, TextHomeAdd.Leave,
        TextFarthersName.Leave, TextFathersBirth.Leave, TextFathersContact.Leave, TextFathersEmail.Leave, TextFathersOccu.Leave,
        TextMothersName.Leave, TextMothersContact.Leave, TextMothersBirth.Leave, TextMotherOccu.Leave, TextMotherEmail.Leave
        Dim txt As TextBox = DirectCast(sender, TextBox)
        If String.IsNullOrWhiteSpace(txt.Text) Then
            Select Case txt.Name
                Case "TextSurName"
                    SetPlaceholder(txt, "Sur Name")
                Case "TextName"
                    SetPlaceholder(txt, "First Name")
                Case "TextMidName"
                    SetPlaceholder(txt, "Middle Name")
                Case "TextDateBirth"
                    SetPlaceholder(txt, "YYYY-MM-DD")
                Case "TextAge"
                    SetPlaceholder(txt, "---")
                Case "TextContact1"
                    SetPlaceholder(txt, "09 ")
                Case "TextPlaceOfBirth"
                    SetPlaceholder(txt, "---")
                Case "TextNationality"
                    SetPlaceholder(txt, "---")
                Case "TextHomeAdd"
                    SetPlaceholder(txt, "Permanent Address")

                Case "TextMothersName"
                    SetPlaceholder(txt, "Full Name")
                Case "TextMothersContact"
                    SetPlaceholder(txt, "09")
                Case "TextMothersBirth"
                    SetPlaceholder(txt, "---")
                Case "TextMotherOccu"
                    SetPlaceholder(txt, "---")
                Case "TextMotherEmail"
                    SetPlaceholder(txt, "---")

                Case "TextFarthersName"
                    SetPlaceholder(txt, "Full Name")
                Case "TextFathersBirth"
                    SetPlaceholder(txt, "---")
                Case "TextFathersContact"
                    SetPlaceholder(txt, "09")
                Case "TextFathersEmail"
                    SetPlaceholder(txt, "---")
                Case "TextFathersOccu"
                    SetPlaceholder(txt, "---")


            End Select
        End If
    End Sub

    ' Helper Method - Set placeholder text with gray color
    Private Sub SetPlaceholder(txt As TextBox, placeholder As String)
        txt.Text = placeholder
        txt.ForeColor = Color.Gray
    End Sub

    ' Optional: Handle TextChanged events if needed
    Private Sub TextSurName_TextChanged(sender As Object, e As EventArgs) Handles TextSurName.TextChanged
        ' Your code for TextSurName_TextChanged (if needed)
    End Sub

    Private Sub TextName_TextChanged(sender As Object, e As EventArgs) Handles TextName.TextChanged
        ' Your code for TextName_TextChanged (if needed)
    End Sub

    Private Sub TextMidName_TextChanged(sender As Object, e As EventArgs) Handles TextMidName.TextChanged
        ' Your code for TextMidName_TextChanged (if needed)
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Dim nextMain As New Form1()
        Form1.Show()

        Me.Hide()
    End Sub
End Class
