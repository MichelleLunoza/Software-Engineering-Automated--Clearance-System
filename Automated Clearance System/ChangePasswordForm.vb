Imports System.Data.SqlClient
Public Class ChangePasswordForm

    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Password As String
        Dim Password2 As String
        Dim username As String

        Try
            con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = AutomatedClearanceDb; Integrated Security = True"
            con.Open()

            cmd.Connection = con
            cmd.CommandText = "SELECT username, password FROM Account WHERE (username = '" & OldUsernameTextBox.Text & "' ) AND (password = '" & OldPassTextBox.Text & "')"

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()

                    Password = reader("password").ToString()
                    username = reader("UserName").ToString()

                    Password2 = OldPassTextBox.Text()

                    If Password = Password2 And username = OldUsernameTextBox.Text Then

                        MessageBox.Show("Successfully retrieve account.", "Account Retrieve", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ValidateButton.Visible = False
                        Panel1.Visible = False
                        Panel2.Visible = True
                        ChangePasswordButton.Visible = True
                    End If
                End While

            Else
                MessageBox.Show("Old username and password do not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                OldUsernameTextBox.Focus()
                OldPassTextBox.Focus()

            End If


        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)

            con.Close()

        End Try

    End Sub

    Private Sub ChangePasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Visible = False
        ChangePasswordButton.Visible = False
    End Sub

    Private Sub ChangePasswordButton_Click(sender As Object, e As EventArgs) Handles ChangePasswordButton.Click
        If (NewPassTextBox.Text <> ConfirmNewPassTextBox.Text) Then
            MessageBox.Show("New password and confirm new password do not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            NewPassTextBox.Clear()
            ConfirmNewPassTextBox.Clear()
            NewPassTextBox.Focus()
        Else
            Dim NewUser = NewUsernameTextBox.Text
            Dim NewPass = NewPassTextBox.Text
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim query As String = String.Empty
            query &= "UPDATE Account SET username=@username,password=@password"


            con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = AutomatedClearanceDb; Integrated Security = True"
            With cmd
                .Connection = con
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@username", NewUser)
                .Parameters.AddWithValue("@password", NewPass)
            End With

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Successfully Updated!")
            LoginForm.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        OldUsernameTextBox.Clear()
        OldPassTextBox.Clear()
        NewUsernameTextBox.Clear()
        NewPassTextBox.Clear()
        ConfirmNewPassTextBox.Clear()
    End Sub
End Class