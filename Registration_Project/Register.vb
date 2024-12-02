Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("EnrollmentDB").ConnectionString

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim confirmPassword As String = txtConfirmPassword.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim fullName As String = txtFullName.Text.Trim()
        Dim userType As String = cmbUserType.SelectedItem?.ToString()

        ' Validate inputs
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) OrElse
           String.IsNullOrEmpty(confirmPassword) OrElse String.IsNullOrEmpty(email) OrElse
           String.IsNullOrEmpty(fullName) OrElse String.IsNullOrEmpty(userType) Then
            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Hash the password
        Dim hashedPassword As String = HashPassword(password)

        ' Save to database
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Users (Username, Password, Email, FullName, UserType, IsActive, CreatedAt) VALUES (@Username, @Password, @Email, @FullName, @UserType, @IsActive, @CreatedAt)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", hashedPassword)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@FullName", fullName)
                    cmd.Parameters.AddWithValue("@UserType", userType)
                    cmd.Parameters.AddWithValue("@IsActive", 1)
                    cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close() ' Optionally close the form
                    Else
                        MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function HashPassword(plainTextPassword As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainTextPassword))
            Return Convert.ToBase64String(hashedBytes)
        End Using
    End Function

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("EnrollmentDB").ConnectionString

        ' Query to fetch user types from the database
        Dim query As String = "SELECT UserTypeId, UserTypeDescription FROM UserTypes"

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Add each user type to the ComboBox
                        cmbUserType.Items.Add(reader("UserTypeDescription").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub
End Class