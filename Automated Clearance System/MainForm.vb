Imports System.Windows.Forms

Public Class MainForm

    Private Sub ClearancesButton_Click(sender As Object, e As EventArgs) Handles ClearancesButton.Click
        ClearanceForm.Show()
        Me.Hide()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ULabel.Text = LoginForm.TypeUserComboBox.SelectedItem.ToString
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult.Yes Then
            MessageBox.Show("Successfully Logout", "Logout")
            LoginForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub CBMSButton_Click(sender As Object, e As EventArgs) Handles CBMSButton.Click

    End Sub
End Class