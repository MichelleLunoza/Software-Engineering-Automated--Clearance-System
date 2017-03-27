Imports System.Data.SqlClient
Public Class LoginForm

    Private Sub ChangePassButton_Click(sender As Object, e As EventArgs) Handles ChangePassButton.Click
        ChangePasswordForm.Show()
        Me.Hide()
    End Sub

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
        Else : usernameTextBox.Text = "" And passwordTextBox.Text = ""
            MessageBox.Show("Please enter your username and password.")
        
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        usernameTextBox.Clear()
        passwordTextBox.Clear()
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
    Private Sub Login()

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Password As String
        Dim Password2 As String
        Dim username As String


        con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = AutomatedClearanceDb; Integrated Security = True"
        con.Open()

        cmd.Connection = con
        cmd.CommandText = "SELECT  username, password FROM Account WHERE (username = '" & usernameTextBox.Text & "' ) AND (password = '" & passwordTextBox.Text & "')"

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
                    usernameTextBox.ReadOnly = True
                    passwordTextBox.ReadOnly = True

                End If
            End While

        Else
            MessageBox.Show("Username and Password do not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            usernameTextBox.Focus()
            passwordTextBox.Focus()

        End If
        con.Close()
    End Sub
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
