Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Configuration


Public Class LoginForm

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If TypeUserComboBox.SelectedItem = "" Then
            MessageBox.Show("Choose type of user.")
        ElseIf TypeUserComboBox.SelectedItem = "Guest" Then
            MessageBox.Show("Logged in successfully as Guest", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MainForm.Show()
            Me.Hide()
        ElseIf TypeUserComboBox.SelectedItem = "Administrator" Then
            Login()
            MainForm.Show()
            Me.Hide()
        End If

        If (usernameTextBox.Text = "" & passwordTextBox.Text = "") Then
            MessageBox.Show("Enter username and password")
        End If

    End Sub
    Private Sub Login()

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Password As String
        Dim Password2 As String
        Dim username As String

        Try
            con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = ClearanceDb; Integrated Security = True"
            con.Open()

            cmd.Connection = con
            cmd.CommandText = "SELECT  username, password FROM Login WHERE (username = '" & usernameTextBox.Text & "' ) AND (password = '" & passwordTextBox.Text & "')"

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()

                    Password = reader("password").ToString()
                    username = reader("UserName").ToString()

                    Password2 = passwordTextBox.Text()

                    If Password = Password2 And username = usernameTextBox.Text Then

                        MessageBox.Show("Logged in successfully as " & username, "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        MainForm.Show()
                        Me.Hide()

                        usernameTextBox.Clear()
                        passwordTextBox.Clear()

                    End If
                End While

            Else
                MessageBox.Show("Username and Password do not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                usernameTextBox.Focus()
                passwordTextBox.Focus()

            End If


        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)

            con.Close()

        End Try
    End Sub

    Private Sub TypeUserComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeUserComboBox.SelectedIndexChanged
        If Me.TypeUserComboBox.SelectedIndex = 0 Then
            Me.usernameTextBox.ReadOnly = False
            Me.passwordTextBox.ReadOnly = False
        Else
            Me.usernameTextBox.ReadOnly = True
            Me.passwordTextBox.ReadOnly = True
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        usernameTextBox.Clear()
        passwordTextBox.Clear()
    End Sub

    Private Sub ChangePassButton_Click(sender As Object, e As EventArgs) Handles ChangePassButton.Click
        Change_Password_Form.Show()
        Me.Hide()
    End Sub
End Class
