Public Class Login
    ' Track number of failed attempts
    Private loginAttempts As Integer = 0

    ' Store sample credentials (replace with actual user validation logic if needed)
    Private Const validUsername As String = "admin"
    Private Const validPassword As String = "1234"

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"c
    End Sub

    ' Logic for login button click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        ' Check if credentials are correct
        If username = validUsername And password = validPassword Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Open the main form and hide the login form
            Dim nextAdmin As New Form1()
            Admin.Show()
            Me.Hide()
        Else
            ' Increment failed attempts
            loginAttempts += 1
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Lock out after 3 failed attempts
            If loginAttempts >= 3 Then
                MessageBox.Show("Too many failed attempts. Application will now exit.", "Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Application.Exit()
            End If
        End If
    End Sub

    ' Optional: Button to close the application
    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Dim nextMain As New Form1()
        Form1.Show()
        Me.Hide()
    End Sub

    ' Optional: Event handlers for textboxes (can be removed if not used)
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Code to handle username input changes, if needed
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' Code to handle password input changes, if needed
    End Sub
End Class
