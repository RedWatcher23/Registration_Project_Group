Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class Login
    ' Track number of failed attempts
    Private loginAttempts As Integer = 0

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"c
    End Sub

    ' Logic for login button click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("EnrollmentDB").ConnectionString
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT Password, UserType FROM Users WHERE Username = @Username AND IsActive = 1"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", username)
                Dim reader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim hashedPassword As String = reader("Password").ToString()
                    Dim userType As String = reader("UserType").ToString()

                    If VerifyPassword(password, hashedPassword) Then
                        MessageBox.Show($"Welcome, {userType}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Navigate to main form or dashboard
                        Dim nextAdmin As New Form1()
                        Admin.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Invalid username or user is inactive.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Function VerifyPassword(plainTextPassword As String, hashedPassword As String) As Boolean
        ' Hash the input password and compare with the stored hash
        Using sha256 As SHA256 = sha256.Create()
            Dim hashedInput As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainTextPassword))
            Dim hashedInputStr = Convert.ToBase64String(hashedInput)
            Return hashedInputStr = hashedPassword
        End Using
    End Function

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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim register As New Register()
        register.Show()
        Me.Hide()
    End Sub
End Class
