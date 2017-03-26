Public Class ClearanceForm

    Private Sub ClearanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ULabel.Text = LoginForm.TypeUserComboBox.SelectedItem.ToString
        If ULabel.Text = "Guest" Then
            BCButton.Enabled = False
            CIButton.Enabled = False
        End If
    End Sub

    Private Sub BCButton_Click(sender As Object, e As EventArgs) Handles BCButton.Click
        BrgyClearanceForm.Show()
        Me.Hide()
    End Sub

    Private Sub CIButton_Click(sender As Object, e As EventArgs) Handles CIButton.Click
        CertificateIndigencyForm.Show()
        Me.Hide()
    End Sub

    Private Sub BCDButton_Click(sender As Object, e As EventArgs) Handles BCDButton.Click
        BrgyClearanceDetailsForm.Show()
        Me.Hide()
    End Sub

    Private Sub CIDButton_Click(sender As Object, e As EventArgs) Handles CIDButton.Click
        CertificateIndigencyDetailsForm.Show()
        Me.Hide()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        MainForm.Show()
        Me.Hide()
    End Sub
End Class