Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Change_Password_Form

    Private Sub ChangePasswordButton_Click(sender As Object, e As EventArgs) Handles ChangePasswordButton.Click
   
   

        ChangePA()
    

    End Sub

    Private Sub RetrieveOldAccount()

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Password As String
        Dim Password2 As String
        Dim username As String


        con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = ClearanceDb; Integrated Security = True"
        con.Open()

        cmd.Connection = con
        cmd.CommandText = "SELECT  username, password FROM Login WHERE (username = '" & OldUsernameTextBox.Text & "' ) AND (password = '" & OldPassTextBox.Text & "')"

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()

                Password = reader("password").ToString()
                username = reader("UserName").ToString()

                Password2 = OldPassTextBox.Text()

                If Password = Password2 And username = OldUsernameTextBox.Text Then
                    MessageBox.Show("Successfully retrieve last account")
                    Panel1.Visible = False
                    Panel2.Visible = True
                    ValidateButton.Visible = False
                    ChangePasswordButton.Visible = True
                End If
            End While
        ElseIf OldUsernameTextBox.Text = "" And OldUsernameTextBox.Text = "" Then
            MessageBox.Show("Please provide the old username and password.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("Old username and old password do not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        con.Close()
    End Sub


    Private Sub ChangePA()
        Dim username = NewUsernameTextBox.Text
        Dim password = NewPassTextBox.Text
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Dim query As String = String.Empty
        query &= "UPDATE Login SET username=@username,password=@password WHERE (username=@username AND password=@password)"


        con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = ClearanceDb; Integrated Security = True"
        With cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@username", username)
            .Parameters.AddWithValue("@password", password)
        End With

        If NewPassTextBox.Text <> ConfirmNewPassTextBox.Text Then
            MessageBox.Show("Your new password does not match to the confirm new password. Please try again")
            NewPassTextBox.Clear()
            ConfirmNewPassTextBox.Clear()
            ConfirmNewPassTextBox.Focus()
            NewPassTextBox.Focus()
        End If

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully Updated!")
            LoginForm.Show()
            Me.Hide()

   

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try
    End Sub

    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        RetrieveOldAccount()
    End Sub

    Private Sub Change_Password_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Visible = False
        ChangePasswordButton.Visible = False
    End Sub
End Class