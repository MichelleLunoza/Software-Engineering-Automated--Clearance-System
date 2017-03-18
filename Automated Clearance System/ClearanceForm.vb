Public Class ClearanceForm

    Private Sub BCButton_Click(sender As Object, e As EventArgs) Handles BCButton.Click
        Brgy_Clearance_Form.Show()
        Me.Hide()
    End Sub

    Private Sub CIButton_Click(sender As Object, e As EventArgs) Handles CIButton.Click
        Certificate_Indigency_Form.Show()
        Me.Hide()
    End Sub

    Private Sub ClearanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ULabel.Text = LoginForm.TypeUserComboBox.SelectedItem.ToString
        If ULabel.Text = "Guest" Then
            BCButton.Enabled = False
            CIButton.Enabled = False
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub BCDButton_Click(sender As Object, e As EventArgs) Handles BCDButton.Click
        Brgy_Clearance_Details_Form.Show()
        Me.Hide()
    End Sub

    Private Sub CIDButton_Click(sender As Object, e As EventArgs) Handles CIDButton.Click
        Certificate_Indigency_Details_Form.Show()
        Me.Hide()
    End Sub
End Class